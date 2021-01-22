using EDDLL.Tickets;
using EDRules.Models;
using EDRules.ViewModels.ModelsVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EDRules.Data
{
    public class SQL
    {
        private static string connString = EDDLL.Data.SQL.Grab.connString;
        private SqlConnection con;
        private SqlCommand cmd;

        public SQL() { }

        #region DataBinds

        private ObservableCollection<vmRule> _rulesList;
        public ObservableCollection<vmRule> rulesList
        {
            get { return _rulesList ?? (_rulesList = new ObservableCollection<vmRule>()); }
            set { this._rulesList = value; }
        }      

        #endregion

        #region Grab

        public void grabRulesInfo()
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    grabRules();
                    grabTicketRules();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grabRules()
        {
            cmd = new SqlCommand("rulesList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                vmRule rule = new vmRule(Models.Rule.CreateRule(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString()), rulesList);
                rulesList.Add(rule);

                grabLegacyID(rule);
                grabParameters(rule);
                grabRuleParameters(rule);
                grabRuleMeasurements(rule);

                rule.saveProperties();
                rule.checkStatus();
            }

            dr.Close();
            cmd.Dispose();
        }

        private void grabLegacyID(vmRule rule)
        {
            cmd = new SqlCommand("returnLegacyID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_rule", rule._rule.Id_Rule));
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                rule._rule.LegacyIDDesc = dr[0].ToString();

            dr.Close();
            cmd.Dispose();
        }
        private void grabParameters(vmRule rule)
        {
            cmd = new SqlCommand("componentsList", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                rule.SpecificHarnessComponentParameters.Add(new vmRuleComponent(rule, Component.CreateComponent(Convert.ToInt32(dr[0]), dr[1].ToString())));

            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("milestonesList", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while (dr.Read())
                rule.MilestoneParameters.Add(new vmRuleMilestone(rule, Milestone.CreateMilestone(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString())));

            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("cpscHarnessList", con);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while (dr.Read())
                rule.HarnessParameters.Add(new vmRuleCPSC(rule, CPSC.CreateCPSC(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString())));

            dr.Close();
            cmd.Dispose();
        }
        private void grabRuleParameters(vmRule rule)
        {
            int id_rule = rule._rule.Id_Rule;
            cmd = new SqlCommand("ruleComponentsList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ruleId", id_rule));

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int id = Convert.ToInt32(dr[0]);
                
                foreach (vmRuleComponent component in rule.SpecificHarnessComponentParameters)
                    if (id == component._component.Id_Component) { component.selectedBool = true; component._component.Id_Rule = id_rule; break; }                
            }

            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("ruleMilestoneList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ruleId", id_rule));

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int id = Convert.ToInt32(dr[0]);

                foreach (vmRuleMilestone milestone in rule.MilestoneParameters)
                    if (id == milestone._milestone.Id_Milestone) { milestone.selectedBool = true; milestone._milestone.Id_Rule = id_rule; break; }
            }

            dr.Close();
            cmd.Dispose();

            cmd = new SqlCommand("ruleCPSCHarnessList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ruleId", id_rule));

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int id = Convert.ToInt32(dr[0]);

                foreach (vmRuleCPSC cpscHarness in rule.HarnessParameters)
                    if (id == cpscHarness._cpsc.Id_CPSC) { cpscHarness.selectedBool = true; cpscHarness._cpsc.Id_Rule = id_rule; break; }
            }

            dr.Close();
            cmd.Dispose();
        }
        public void populateRuleParameters(vmRule rule)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();

                    grabParameters(rule);
                    
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void grabRuleMeasurements(vmRule rule)
        {
            cmd = new SqlCommand("ruleMeasurementsList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ruleId", rule._rule.Id_Rule));

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                rule.RuleMeasurements.Add(new vmMeasurement(Models.Measurement.CreateMeasurement(Convert.ToInt32(dr[0]), rule._rule.Id_Rule, dr[1].ToString()), rule.RuleMeasurements));

            dr.Close();
            cmd.Dispose();
        }

        private void grabTicketRules()
        {
            cmd = new SqlCommand("ticketRuleList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@userDesc", Environment.UserName.ToUpper()));
            cmd.Parameters.Add(new SqlParameter("@adminBool", 1));

            SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //    ticketRulesList.Add(new vmEDRulesTicket(Ticket.createTicket(Convert.ToInt32(dr[1]), Convert.ToInt32(dr[3]), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),
            //                                                                dr[8].ToString(), dr[9].ToString(), Convert.ToDateTime(dr[10]), Convert.ToDateTime(dr[11]), dr[12].ToString()),
            //                                                                Convert.ToInt32(dr[0]), Convert.ToInt32(dr[2])));
            dr.Close();
            cmd.Dispose();
        }

        #endregion

        #region Add       

        public void addRule(vmRule rule)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();

                    cmd = new SqlCommand("addRule", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ruleType", "Rule"));
                    cmd.Parameters.Add(new SqlParameter("@designRule", rule.DesignRule));
                    cmd.Parameters.Add(new SqlParameter("@ruleName", rule.RuleName));
                    cmd.Parameters.Add(new SqlParameter("@ruleDesc", rule.RuleDesc));
                    cmd.Parameters.Add(new SqlParameter("@checkMethod", rule.RuleCheckDesc));
                    cmd.Parameters.Add(new SqlParameter("@repairMethod", rule.RuleRepairDesc));

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("Select @@Identity;", con);

                    rule._rule.Id_Rule = Convert.ToInt32(cmd.ExecuteScalar());

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addLegacyID(vmRule rule)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    cmd = new SqlCommand("addLegacyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_rule", rule._rule.Id_Rule));
                    cmd.Parameters.Add(new SqlParameter("@legacyIDDesc", rule.LegacyIDDesc));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addRuleMeasurement(vmMeasurement measurement)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    cmd = new SqlCommand("addRuleMeasurement", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_rule", measurement._measurement.Id_Rule));
                    cmd.Parameters.Add(new SqlParameter("@measurementDesc", measurement.MeasurementDesc));

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("Select @@Identity;", con);

                    measurement._measurement.Id_Measurement = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addRuleParameter(vmParameter parameter)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                  
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Edit

        public void editRule(vmRule rule)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    cmd = new SqlCommand("editRule", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_rule", rule._rule.Id_Rule));
                    cmd.Parameters.Add(new SqlParameter("@ruleType", "Rule"));
                    cmd.Parameters.Add(new SqlParameter("@designRule", rule.DesignRule));
                    cmd.Parameters.Add(new SqlParameter("@ruleName", rule.RuleName));
                    cmd.Parameters.Add(new SqlParameter("@ruleDesc", rule.RuleDesc));
                    cmd.Parameters.Add(new SqlParameter("@checkMethod", rule.RuleCheckDesc));
                    cmd.Parameters.Add(new SqlParameter("@repairMethod", rule.RuleRepairDesc));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       

        public void editLegacyID(vmRule rule)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    cmd = new SqlCommand("editLegacyID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_rule", rule._rule.Id_Rule));
                    cmd.Parameters.Add(new SqlParameter("@legacyIDDesc", rule.LegacyIDDesc));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void editRuleMeasurement(vmMeasurement measurement)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    cmd = new SqlCommand("editRuleMeasurement", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_ruleMeasurement", measurement._measurement.Id_Measurement));
                    cmd.Parameters.Add(new SqlParameter("@measurementDesc", measurement.MeasurementDesc));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Remove

        public void removeRule(vmRule rule)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    cmd = new SqlCommand("removeRule", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_rule", rule._rule.Id_Rule));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void removeRuleMeasurement(vmMeasurement measurement)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    cmd = new SqlCommand("removeRuleMeasurement", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_ruleMeasurement", measurement._measurement.Id_Measurement));

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void removeRuleParameter(vmParameter parameter)
        {
            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       

        #endregion

        #region Methods

        #endregion
    }
}
