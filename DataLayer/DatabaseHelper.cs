// Capa de Datos: Aquí manejamos la conexión a la base de datos
// Archivo: DatabaseHelper.cs
using System;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DatabaseHelper
    {
        // Cadena de conexión para la base de datos
        private string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

        // Método para obtener una conexión a la base de datos
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
