// objetos 3D Paredes, repiza, auto

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game(800, 600,"Objetos en 3D"))
            {
                game.Run(60, 0); // corre el juego a 30 fps
            }
        }
    }
}
