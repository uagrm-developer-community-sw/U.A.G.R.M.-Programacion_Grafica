using OpenTK; // Importa la librería OpenTK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500, 500); // Crea una ventana de 500x500 pixeles
            Game gm = new Game(window); // Crear un objeto de la clase Game y le pasa la ventana como parametro
            
        }
    }
}
