using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args) // Punto de entrada del programa
        {
            using (Game game = new Game(800, 600, "Letra T")) // Ventana de 800x600 con título "Letra T"
            {
                game.Run(60.0); // Correr a 60 FPS
            }
        }
    }
}
