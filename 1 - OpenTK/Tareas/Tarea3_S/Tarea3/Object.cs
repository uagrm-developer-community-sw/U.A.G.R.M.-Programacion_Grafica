using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    internal class Object // Clase que representa un objeto 3D
    {
        private List<Face> faces; // lista de caras que componen el objeto
        private float[] centroid; // centroide del objeto en el espacio

        public Object(float[] centroid) // constructor por defecto
        {
            this.centroid = centroid; // inicializa el centroide
            faces = new List<Face>(); // inicializa la lista de caras
        }

        public Object(float[] centroid, List<Face> faces) // constructor con parámetros de centroide y lista de caras
        {
            this.centroid = centroid; // inicializa el centroide con el valor dado
            this.faces = faces; // inicializa la lista de caras con la lista dada
        }

        public void draw() // método que dibuja el objeto
        {
            foreach (Face face in faces) // itera sobre todas las caras en la lista de caras
            {
                face.draw(centroid); // dibuja la cara con el centroide del objeto
            }
        }
        
        public void addFace(Face face) // método que agrega una cara a la lista de caras del objeto
        {
            faces.Add(face); // agrega la cara a la lista de caras
        }

        public void removeFace(Face face) // método que remueve una cara de la lista de caras del objeto
        {
            faces.Remove(face); // remueve la cara de la lista de caras
        }
    }
}
