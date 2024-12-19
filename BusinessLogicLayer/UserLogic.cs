// Capa de Lógica de Negocio: Aquí ponemos las reglas del negocio y la lógica principal
// Archivo: UserLogic.cs
using System;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class UserLogic
    {
        // Usamos la capa de datos para conectar a la base de datos
        private DatabaseHelper dbHelper = new DatabaseHelper();

        // Devuelve un mensaje de bienvenida
        public string GetWelcomeMessage()
        {
            return "Hola, bienvenido a este ejemplo de 3 capas.";
        }

        // Devuelve el total de usuarios desde la base de datos
        public int GetUserCount()
        {
            using (var connection = dbHelper.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users", connection);
                return (int)command.ExecuteScalar();
            }
        }
    }
}