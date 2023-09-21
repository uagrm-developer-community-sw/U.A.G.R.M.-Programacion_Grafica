using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game(800, 600, "Práctico Nº 2 Dibujo de una mesa"))
            {
                game.Run(60.0);
            }
        }
    }
}
