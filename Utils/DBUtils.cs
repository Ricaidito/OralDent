using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;

namespace OralDent.Utils
{
    public static class DBUtils
    {
        //Data Source = server; Database = db; Integrated Security = true;
        // ConnectionString
        private static string cString = "Data Source = .; Database = Odontologia; Integrated Security = true;";
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

        public static string GetMontoTotal(int idPaciente)
        {
            string monto;

            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT SUM(Monto) AS Total FROM Servicio WHERE IdPaciente = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", idPaciente);

                    con.Open();

                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();

                    monto = r["Total"].ToString();
                }

            }

            return monto;
        }

        public static string[] GetNameAndLastName(int idPaciente)
        {
            string[] nombres = new string[2];

            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT Nombre, Apellido FROM Paciente WHERE IdPaciente = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", idPaciente);

                    con.Open();

                    SqlDataReader r = cmd.ExecuteReader();
                    r.Read();

                    nombres[0] = r["Nombre"].ToString();
                    nombres[1] = r["Apellido"].ToString();
                }

            }

            return nombres;
        }

        public static DataTable GetTable(string table, string c1)
        {
            DataTable dt = new DataTable();

            using (var con = new SqlConnection(cString))
            {
                string query = $"SELECT {c1} FROM {table};";

                using (var cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }

            }

            return dt;
        }

        public static DataTable GetTable(string table, string c1, string c2)
        {
            DataTable dt = new DataTable();

            using (var con = new SqlConnection(cString))
            {
                string query = $"SELECT {c1}, {c2} FROM {table};";

                using (var cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }

            }

            return dt;
        }

        public static DataTable GetTable(string table, string c1, string c2, string c3)
        {
            DataTable dt = new DataTable();

            using (var con = new SqlConnection(cString))
            {
                string query = $"SELECT {c1}, {c2}, {c3} FROM {table};";

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

        public static bool CheckIfSucursalExist(int id)
        {
            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT NombreSucursal FROM Sucursal WHERE IdSucursal = @id;";

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
            UpdateAsistenteRef(id);
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

        // Asistente 
        public static bool CheckIfAsistenteExists(int id)
        {
            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT Nombre FROM Asistente WHERE IdAsistente = @id;";

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

        public static void AddAsistente(
            string name,
            string lastName,
            string phoneNumber,
            int salary,
            int idDent
            )
        {
            using (var con = new SqlConnection(cString))
            {
                string query = @"INSERT INTO 
                    Asistente(Nombre, Apellido, Telefono, Salario, IdDentista) 
                    VALUES(@name, @lastName, @tel, @sal, @idDent);";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("lastName", lastName);
                    cmd.Parameters.AddWithValue("tel", phoneNumber);
                    cmd.Parameters.AddWithValue("sal", salary);
                    cmd.Parameters.AddWithValue("idDent", idDent);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAsistente(int id)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = "DELETE FROM Asistente WHERE IdAsistente = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void UpdateAsistenteRef(int dentistId)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = "UPDATE Asistente SET IdDentista = NULL WHERE IdDentista = @dentistId;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("dentistId", dentistId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateAsistente(
            int id,
            string name,
            string lastName,
            string phone,
            int salary,
            int dentistId
            )
        {
            using (var con = new SqlConnection(cString))
            {
                string query = @"UPDATE Asistente SET 
                    Nombre = @name, 
                    Apellido = @lastName, 
                    Telefono = @tel, 
                    Salario = @sal,
                    IdDentista = @dentistId
                    WHERE IdAsistente = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("lastName", lastName);
                    cmd.Parameters.AddWithValue("tel", phone);
                    cmd.Parameters.AddWithValue("sal", salary);
                    cmd.Parameters.AddWithValue("dentistId", dentistId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Consultas
        public static bool CheckIfConsultaExists(int id)
        {
            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT IdConsulta FROM Consulta WHERE IdConsulta = @id;";

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

        public static void AddConsulta(DateTime date, string desc, int idDentista, int idPaciente, int idSucursal)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = @"INSERT INTO 
                    Consulta(Fecha, Descripcion, IdPaciente, IdDentista, idSucursal) 
                    VALUES(@date, @desc, @idP, @idD, @idS);";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("desc", desc);
                    cmd.Parameters.AddWithValue("idP", idPaciente);
                    cmd.Parameters.AddWithValue("idD", idDentista);
                    cmd.Parameters.AddWithValue("idS", idSucursal);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteConsulta(int id)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = "DELETE FROM Consulta WHERE IdConsulta = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateConsulta(int id, DateTime date, string desc, int idDentista, int idPaciente, int idSucursal)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = @"UPDATE Consulta SET 
                    Fecha = @date, 
                    Descripcion = @desc, 
                    IdPaciente = @idP,
                    IdDentista = @idD,
                    IdSucursal = @idS
                    WHERE IdConsulta = @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("desc", desc);
                    cmd.Parameters.AddWithValue("idP", idPaciente);
                    cmd.Parameters.AddWithValue("idD", idDentista);
                    cmd.Parameters.AddWithValue("idS", idSucursal);
                    cmd.Parameters.AddWithValue("id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Servicio
        public static bool CheckIfServicioExists(int id)
        {
            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT Nombre FROM Servicio WHERE IdServicio = @id;";

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

        public static bool CheckIfPacienteHasService(int id)
        {
            using (var con = new SqlConnection(cString))
            {

                string query = "SELECT Monto FROM Servicio WHERE IdPaciente = @id;";

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

        public static void AddServicio(int money, string tipoServicio, int idPaciente, int idDentista)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = @"INSERT INTO 
                    Servicio(Monto, TipoServicio, IdPaciente, IdDentista) 
                    VALUES(@monto, @tipoServ, @idP, @idD);";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("monto", money);
                    cmd.Parameters.AddWithValue("tipoServ", tipoServicio);
                    cmd.Parameters.AddWithValue("idP", idPaciente);
                    cmd.Parameters.AddWithValue("idD", idDentista);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Factura
        public static void GenerarFactura(Factura factura)
        {
            using (var con = new SqlConnection(cString))
            {
                string query = $"EXECUTE spGenerarFactura @monto, @fecha, @id;";

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("monto", factura.montoTotal);
                    cmd.Parameters.AddWithValue("fecha", factura.fecha);
                    cmd.Parameters.AddWithValue("id", factura.idPaciente);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
