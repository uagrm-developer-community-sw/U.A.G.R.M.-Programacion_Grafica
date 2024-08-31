using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    internal class Stage // Clase que representa un escenario en el que se pueden agregar objetos
    {
        private List<Object> objects; // Lista de objetos en el escenario
        public Stage() // Constructor por defecto de la clase escenario
        {
            objects = new List<Object>(); // Inicializa la lista de objetos en el escenario
        }

        public void draw() // Método que dibuja todos los objetos en el escenario 
        {
            foreach (Object obj in objects) // Itera sobre todos los objetos en la lista de objetos
            {
                obj.draw(); // Dibuja el objeto
            }
        }

        public void addObject(Object object3D) // Método que agrega un objeto a la lista de objetos en el escenario
        {
            objects.Add(object3D); // Agrega el objeto a la lista de objetos
        }

        public void removeObject(Object object3D) // Método que remueve un objeto de la lista de objetos en el escenario
        {
            objects.Remove(object3D); // Remueve el objeto de la lista de objetos
        }
    }
}

