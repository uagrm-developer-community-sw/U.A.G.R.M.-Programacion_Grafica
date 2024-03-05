using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK; // Importa la librería OpenTK
using OpenTK.Graphics; // Importa la librería OpenTK.Graphics

namespace opentk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500, 500); // Crea una ventana con resolución de 800x600
            Game gm = new Game(window); // Crea un juego con la ventana
        }
    }
}
