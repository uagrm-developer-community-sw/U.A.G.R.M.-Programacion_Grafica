using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Triangulo_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500,500);
            Triangulo_2D gm = new Triangulo_2D(window);
        }
    }
}
