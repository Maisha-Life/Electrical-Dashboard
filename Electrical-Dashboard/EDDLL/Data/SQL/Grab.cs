using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EDDLL.Data.SQL
{
    public class Grab
    {
        public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ElectricalDashboardDB ;Integrated Security=True;MultipleActiveResultSets=true";
        private SqlConnection con;

        public List<string> rulesList { get; set; }
        public List<string> toolsList { get; set; }
        public List<string> ticketsList { get; set; }

        public Grab()
        {
            rulesList = new List<string>();
            toolsList = new List<string>();
            ticketsList = new List<string>();

            try
            {
                using (con = new SqlConnection(connString))
                {
                    con.Open();
                    grabRules();
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
            SqlCommand sqlCommand = new SqlCommand("rulesList", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                rulesList.Add(sqlDataReader[0].ToString());
            }

            sqlDataReader.Close();

            sqlCommand.Dispose();
        }

        private void grabTools()
        {
            SqlCommand sqlCommand = new SqlCommand("toolsList", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                toolsList.Add(sqlDataReader[0].ToString());
            }

            sqlDataReader.Close();

            sqlCommand.Dispose();
        }
    }
}
