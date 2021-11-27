using System.Configuration;
using System.Data.SqlClient;

namespace OralDent.Utils
{
    public static class DBUtils
    {
        private static string cString = ConfigurationManager
            .ConnectionStrings["cString"]
            .ConnectionString;

        public static bool CheckCredentials(string user, string pass)
        {
            bool check = false;

            using(var con = new SqlConnection(cString))
            {

                string query = $"SELECT Usuario, Clave from Usuarios WHERE Usuario = @user AND Clave = @pass;";

                using(var cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("user", user);
                    cmd.Parameters.AddWithValue("pass", pass);

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
            string name = string.Empty;

            using (var con = new SqlConnection(cString))
            {

                string query = $"SELECT Nombre FROM Usuarios WHERE Usuario = @user;";

                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("user", user);

                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();

                    name = r["Nombre"].ToString();
                }

            }

            return name;
        }
    }
}
