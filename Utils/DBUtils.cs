using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OralDent.Utils
{
    public static class DBUtils
    {
        private static string cString = ConfigurationManager
            .ConnectionStrings["cString"]
            .ConnectionString;

        public static DataTable GetTable(string table)
        {
            DataTable dt = new DataTable();

            using (var con = new SqlConnection(cString))
            {
                string query = $"SELECT * FROM {table};";

                using (var cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }

            }

            return dt;
        }

        public static bool CheckCredentials(string user, string pass)
        {
            bool check = false;

            using(var con = new SqlConnection(cString))
            {

                string query = "SELECT Usuario, Clave from Usuarios WHERE Usuario = @user AND Clave = @pass;";

                using(var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("user", user);
                    cmd.Parameters.AddWithValue("pass", pass);

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
            string name = string.Empty;

            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT Nombre FROM Usuarios WHERE Usuario = @user;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("user", user);
                    
                    con.Open();

                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();

                    name = r["Nombre"].ToString();
                }

            }

            return name;
        }

        public static void AddPaciente(
            string name, 
            string lastName, 
            string cedula, 
            string email, 
            int age, 
            string phone, 
            string tipoPaciente
            )
        {
            using(var con = new SqlConnection(cString))
            {
                string query = @"INSERT INTO 
                    Paciente(Nombre, Apellido, Cedula, Correo, Edad, Telefono, TipoPaciente) 
                    VALUES(@name, @lastName, @cedula, @correo, @edad, @telefono, @tipoPaciente);";

                using (var cmd = new SqlCommand(query, con)) 
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("lastName", lastName);
                    cmd.Parameters.AddWithValue("cedula", cedula);
                    cmd.Parameters.AddWithValue("correo", email);
                    cmd.Parameters.AddWithValue("edad", age);
                    cmd.Parameters.AddWithValue("telefono", phone);
                    cmd.Parameters.AddWithValue("tipoPaciente", tipoPaciente);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeletePaciente(int id)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = "DELETE FROM Paciente WHERE IdPaciente = @id";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
