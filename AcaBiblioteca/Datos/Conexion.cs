using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace AcaBiblioteca.Datos
{
    public class Conexion
    {   
        private string cadenaConexion = "server=(localdb)\\MSSQLLocalDB;database=AcaBiblioteca;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection obtenerConexion()
        {

            return new SqlConnection(cadenaConexion);
        }
    }
}