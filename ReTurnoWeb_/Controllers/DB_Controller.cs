using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTurnoWeb_.Controllers
{
    public static class DB_Controller
    {

        private static string connectionString = "";
        public static SqlConnection connection;

        public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();

            //builder.DataSource = @"(localdb)\Local"; //NOMBRE DEL SERVIDOR
            //cadenas sql
            builder.DataSource = @"DESKTOP-8Q1CKL2\SQLEXPRESS";
            //builder.DataSource = @"PROGRAMACION02\SQLEXPRESS"; 
            builder.InitialCatalog = "ReTurno"; //NOMBRE DE LA BASE DE DATOS
            builder.IntegratedSecurity = true; //TIENE O NO SEGURIDAD INTEGRADA CON WINDOWS
            builder.MultipleActiveResultSets = true;
            builder.TrustServerCertificate = true;

            connectionString = builder.ToString();
            connection = new SqlConnection(connectionString);

            Trace.WriteLine("Conexion a la DB: " + connection);
            connection.Open();
            connection.Close();

        }

        public static void close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static void open() {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

    }
}
