using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace OralDent.Utils
{
    public static class DBUtils
    {
        private static string cString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
        private static SqlConnection con;

        public static bool CheckCredentials(string user, string pass)
        {
            bool check = false;
            using(con = new SqlConnection(cString))
            {
                string query = $"SELECT Usuario, Clave from Usuarios WHERE Usuario = '{user}' AND Clave = '{pass}';";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();

                    if (r.HasRows)
                    {
                        if (user == r["Usuario"].ToString() && pass == r["Clave"].ToString())
                            check = true;
                    }
                    else
                        check = false;
                }
            }
            return check;
        }

        public static string GetName(string user)
        {
            string result = string.Empty;
            using (con = new SqlConnection(cString))
            {
                string query = $"SELECT Nombre FROM Usuarios WHERE Usuario = '{user}';";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();
                    result = r["Nombre"].ToString();
                }
            }
            return result;
        }

    }
}
