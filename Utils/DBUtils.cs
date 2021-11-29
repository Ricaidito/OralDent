using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OralDent.Utils
{
    public static class DBUtils
    {
        // ConnectionString en App.config
        private static string cString = ConfigurationManager
            .ConnectionStrings["cString"]
            .ConnectionString;

        // Utilidades
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

        // Paciente
        public static bool CheckIfPacienteExists(int id)
        {
            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT Nombre FROM Paciente WHERE IdPaciente = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);

                    con.Open();

                    SqlDataReader r = cmd.ExecuteReader();

                    if (r.HasRows)
                        return true;
                    return false;
                }

            }
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

        public static void UpdatePaciente(
            int id,
            string name,
            string lastName,
            string cedula,
            string email,
            int age,
            string phone,
            string tipoPaciente
            )
        {
            using (var con = new SqlConnection(cString))
            {
                string query = @"UPDATE Paciente SET 
                    Nombre = @name, 
                    Apellido = @lastName, 
                    Cedula = @cedula, 
                    Correo = @correo, 
                    Edad = @edad, 
                    Telefono = @tel, 
                    TipoPaciente = @tipoPaciente 
                    WHERE IdPaciente = @id;";

                using(var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("lastName", lastName);
                    cmd.Parameters.AddWithValue("cedula", cedula);
                    cmd.Parameters.AddWithValue("correo", email);
                    cmd.Parameters.AddWithValue("edad", age);
                    cmd.Parameters.AddWithValue("tel", phone);
                    cmd.Parameters.AddWithValue("tipoPaciente", tipoPaciente);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Dentista
        public static bool CheckIfDentistaExists(int id)
        {
            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT Nombre FROM Dentista WHERE IdDentista = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);

                    con.Open();

                    SqlDataReader r = cmd.ExecuteReader();

                    if (r.HasRows)
                        return true;
                    return false;
                }

            }
        }

        public static void AddDentista(
            string name, 
            string lastName, 
            string phoneNumber, 
            int salary, 
            string especialidad
            )
        {
            using (var con = new SqlConnection(cString))
            {
                string query = @"INSERT INTO 
                    Dentista(Nombre, Apellido, Telefono, Salario, Especialidad) 
                    VALUES(@name, @lastName, @tel, @sal, @especialidad);";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("lastName", lastName);
                    cmd.Parameters.AddWithValue("tel", phoneNumber);
                    cmd.Parameters.AddWithValue("sal", salary);
                    cmd.Parameters.AddWithValue("especialidad", especialidad);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteDentista(int id)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = "DELETE FROM Dentista WHERE IdDentista = @id";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateDentista(
            int id,
            string name,
            string lastName,
            string phone,
            int salary,
            string especialidad
            )
        {
            using (var con = new SqlConnection(cString))
            {
                string query = @"UPDATE Dentista SET 
                    Nombre = @name, 
                    Apellido = @lastName, 
                    Telefono = @tel, 
                    Salario = @sal,
                    Especialidad = @especialidad
                    WHERE IdDentista = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("lastName", lastName);
                    cmd.Parameters.AddWithValue("tel", phone);
                    cmd.Parameters.AddWithValue("sal", salary);
                    cmd.Parameters.AddWithValue("especialidad", especialidad);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Consulta 

    }
}
