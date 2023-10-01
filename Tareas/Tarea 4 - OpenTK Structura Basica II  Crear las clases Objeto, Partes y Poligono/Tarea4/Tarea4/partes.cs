using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class partes
    {
        private Dictionary<String, poligono> poligonos; // Diccionario de polígonos

        public partes() // Constructor
        {
            poligonos = new Dictionary<String, poligono>(); // Inicializamos el diccionario
        }

        public void addPoligono(String name, poligono poligono) // Método para añadir un polígono al diccionario
        {
            poligonos.Add(name, poligono); // Añadimos el polígono al diccionario
        }

        public void removePoligono(String name) // Método para eliminar un polígono del diccionario
        {
            poligonos.Remove(name); // Eliminamos el polígono del diccionario
        }

        public void draw(Vector3d centro) // Método para dibujar todos los polígonos de la parte
        {
            Vector3d centroTotal = new Vector3d(0, 0, 0); // Inicializamos el centro de masa total en (0, 0, 0)

            foreach (poligono poligono in poligonos.Values) // Recorremos todos los polígonos de la parte
            {
                // Calculamos el centro de masa del polígono
                Vector3d centroPoligono = poligono.CalcularCentroDeMasa(); // Llamamos al método de cálculo del centro de masa del polígono

                // Sumamos el centro de masa del polígono al centro de masa total
                centroTotal += centroPoligono;

                // Llamamos al método de dibujo del polígono pasándole su centro de masa
                poligono.draw(centroPoligono);
            }

            // Calculamos el centro de masa total dividiendo por el número de polígonos
            if (poligonos.Count > 0)
            {
                centroTotal /= poligonos.Count; // Dividimos el centro de masa total entre el número de polígonos
            }

            // Aquí puedes hacer lo que necesites con el centro de masa total
            Console.WriteLine("Centro de Masa Total: " + centroTotal);
        }
    }
}
