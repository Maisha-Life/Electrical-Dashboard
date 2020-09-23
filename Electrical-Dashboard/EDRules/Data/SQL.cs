using EDDLL.Tickets;
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

        public SQL() { }

        #region DataBinds

        private ObservableCollection<vmRule> _rulesList;
        public ObservableCollection<vmRule> rulesList
        {
            get { return _rulesList ?? (_rulesList = new ObservableCollection<vmRule>()); }
            set { this._rulesList = value; }
        }

        private ObservableCollection<vmEDRulesTicket> _ticketRulesList;
        public ObservableCollection<vmEDRulesTicket> ticketRulesList
        {
            get { return _ticketRulesList ?? (_ticketRulesList = new ObservableCollection<vmEDRulesTicket>()); }
            set { this._ticketRulesList = value; }
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

        public void grabRules()
        {
            SqlCommand sqlCommand = new SqlCommand("rulesList", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = sqlCommand.ExecuteReader();

            while (dr.Read())
                rulesList.Add(new vmRule(Models.Rule.CreateRule(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString()), rulesList));

            dr.Close();

            sqlCommand.Dispose();
        }

        public void grabTicketRules()
        {
            SqlCommand cmd = new SqlCommand("ticketRuleList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@userID", Environment.UserName));
            cmd.Parameters.Add(new SqlParameter("@adminBool", 1));

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                ticketRulesList.Add(new vmEDRulesTicket(Ticket.createTicket(Convert.ToInt32(dr[1]), Convert.ToInt32(dr[3]), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),
                                                                            dr[8].ToString(), dr[9].ToString(), Convert.ToDateTime(dr[10]), Convert.ToDateTime(dr[11]), dr[12].ToString()),
                                                                            Convert.ToInt32(dr[0]), Convert.ToInt32(dr[2])));

            dr.Close();

            cmd.Dispose();
        }

        #endregion

        #region Add

        public int addTicketRule(vmEDRulesTicket ticket)
        {
            SqlCommand cmd = new SqlCommand("addTicket", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ticketType", "Rule"));
            cmd.Parameters.Add(new SqlParameter("@id_ticketType", ticket.Id_TicketRule));
            cmd.Parameters.Add(new SqlParameter("@statusType", ticket.Status));
            cmd.Parameters.Add(new SqlParameter("@importanceLevelType", ticket.ImportanceLevel));
            cmd.Parameters.Add(new SqlParameter("@ticketNumber", ticket.TicketNumber));
            cmd.Parameters.Add(new SqlParameter("@id_subCategory", ticket.SubCategory));
            cmd.Parameters.Add(new SqlParameter("@assigner", ticket.Assigner));
            cmd.Parameters.Add(new SqlParameter("@assignee", ticket.Assignee));
            cmd.Parameters.Add(new SqlParameter("@dateAssigned", ticket.DateAssigned));
            cmd.Parameters.Add(new SqlParameter("@dateDue", ticket.DateDue));
            cmd.Parameters.Add(new SqlParameter("@ticketDesc", ticket.Description));

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("Select @@Identity;", con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void addRule(vmRule rule)
        {
            SqlCommand cmd = new SqlCommand("addTicket", con);
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
        }

        public void addRuleMeasurement(vmMeasurement measurement)
        {
            SqlCommand cmd = new SqlCommand("addRuleMeasurement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_rule", "Rule"));
            cmd.Parameters.Add(new SqlParameter("@measurementDesc", measurement.MeasurementDesc));

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("Select @@Identity;", con);
            
            measurement._measurement.Id_Measurement = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void addRuleParameter(vmParameter parameter)
        {
            SqlCommand cmd = new SqlCommand("addRuleParameter", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_parameter", parameter._parameter.Id_Parameter));
            cmd.Parameters.Add(new SqlParameter("@id_rule", parameter._rule._rule.Id_Rule));

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("Select @@Identity;", con);

            parameter._parameter.Id_Parameter = Convert.ToInt32(cmd.ExecuteScalar());
        }

        #endregion

        #region Edit

        #endregion

        #region Remove

        #endregion

        #region Methods

        #endregion
    }
}
