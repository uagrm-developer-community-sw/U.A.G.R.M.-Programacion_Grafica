using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game(800, 600, "OpenTk")) // instancia de la clase Game
            {
                game.Run(60.0); // corre el juego a 60 fps

                // Detiene el cierre inmediato de la ventana de la consola
                Console.WriteLine("Presiona Enter para cerrar...");
                Console.ReadLine();
            }
        }
    }
}
