using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Tarea2_OpenTK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (game nw = new game(800, 600, "prueba"))
            {
                nw.Run(60.0); // Corre el programa a 60 FPS
            }
        }
    }
}
