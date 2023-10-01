using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class objeto
    {
        private Dictionary<String, partes> partes { get; set; } //partes del objeto

        private Vector3d centro { get; } //centro del objeto

        public objeto(Double x, Double y, Double z) // Constructor
        {
            this.centro = new Vector3d(x, y, z); // Inicializamos el centro del objeto
            partes = new Dictionary<String, partes>(); // Inicializamos el diccionario de partes
        }

        public void addParte(String name, partes parte)
        {
            partes.Add(name, parte);
        }
        public void removeParte(String name) { 
            partes.Remove(name); 
        }

        public Double centroX() { 
            return centro.X; 
        }

        public Double centroY()
        {
            return centro.Y; 
        }

        public Double centroZ()
        {
            return centro.Z; 
        }
        public Vector3d getCentro()
        {
            return centro;
        }

        public void draw()
        {
            foreach (partes parte in partes.Values)
            {
                parte.draw(centro);
            }
        }
    }
}
