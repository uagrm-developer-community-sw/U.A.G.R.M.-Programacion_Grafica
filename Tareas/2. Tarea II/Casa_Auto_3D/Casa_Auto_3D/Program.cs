using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_Auto_3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo una casa
            Casa casa = new Casa();
            casa.Altura = 3;
            casa.Ancho = 5;
            casa.Largo = 10;
            // Creo un auto
            Auto auto = new Auto();
            auto.Altura = 1;
            auto.Ancho = 2;
            auto.Largo = 4;
            // Muestro la casa
            casa.Mostrar();
            // Muestro el auto
            auto.Mostrar();
            // Muestro la casa con el auto adentro
            casa.MostrarConAuto(auto);
            Console.ReadKey();
        }
    }
}
