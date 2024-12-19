// Capa de Presentación: Esta parte interactúa con el usuario
// Archivo: Program.cs
using System;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creamos una instancia de la lógica de negocio
            UserLogic userLogic = new UserLogic();

            // Mostramos el mensaje de bienvenida
            Console.WriteLine(userLogic.GetWelcomeMessage());

            // Mostramos el total de usuarios
            Console.WriteLine("Número total de usuarios: " + userLogic.GetUserCount());
        }
    }
}