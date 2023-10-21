using System;
using System.Data.SqlClient;



namespace DAL
{
    public class Conexion
    {
        SqlConnection conexion = new SqlConnection();
        public SqlConnection Conectar()
        {
            conexion.ConnectionString = "Data Source=(Local);Initial Catalog=Trivia;Integrated Security=True";
            conexion.Open();
            return conexion;
        }

        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }

    }
}
