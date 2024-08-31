using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    internal class Face // Clase que representa una cara de un objeto 3D compuesta por una lista de vértices
    {
        private List<float[]> vertices; // lista de vértices que componen la cara de un objeto
        private Color4 color; // color de la cara

        public Face() // constructor predeterminado para la clase face
        {
            vertices = new List<float[]>();  // inicializar la lista de vértices
        }

        public Face(Color4 color) : this() // constructor con parámetro de color
        {
            this.color = color; // Establece el color
        }

        public void setColor(Color4 color) // Establezca la columnaor
        {
            this.color = color; // Establece el color
        }

        public void draw(float[] objCentroid) // Dibuja la cara con el centroide dado.
        {
            //GL.Begin(PrimitiveType.Polygon);
            GL.Begin(PrimitiveType.LineLoop); // Dibuja una línea que conecta todos los vértices de la cara
            GL.Color4(color); // Establece el color de la cara
            foreach (float[] vertex in vertices) // Itera sobre todos los vértices en la lista de vértices
            {
                GL.Vertex3(objCentroid[0] + vertex[0], objCentroid[1] + vertex[1], objCentroid[2] + vertex[2]); // Dibuja el vértice
            }
            GL.End(); // Finaliza el dibujo de la cara
        }

        public void addVertex(float[] vertex) // Método que agrega un vértice a la lista de vértices de la cara
        {
            vertices.Add(vertex); // Agrega el vértice a la lista de vértices
        }

        public void removeVertex(float[] vertex) // Método que remueve un vértice de la lista de vértices de la cara
        {
            vertices.Remove(vertex); // Remueve el vértice de la lista de vértices
        }

        public List<float[]> getVertices() // Método que devuelve la lista de vértices de la cara
        {
            return vertices; // Devuelve la lista de vértices
        }
    }
}
