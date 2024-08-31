using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args) // Método principal de la aplicación que se llama al iniciar el programa.
        {
            using (Game game = new Game(1000, 800, "OpenTK 3.3.1")) // Crea una nueva ventana de juego con el ancho, la altura y el título indicados.
            {
                game.Run(60.0); // Ejecuta la ventana de juego con una tasa de fotogramas de 60.0 fps.
            }
        }
    }
}
