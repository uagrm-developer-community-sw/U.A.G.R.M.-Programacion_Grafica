using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Face
    {
        private List<float[]> vertices;
        private Color4 color;

        public Face() // default constructor
        {
            vertices = new List<float[]>();  // initialize the list of vertices
        }

        public Face(Color4 color) : this() // constructor with color parameter
        {
            this.color = color; // set the color
        }

        public void setColor(Color4 color) // set the color
        {
            this.color = color; // set the color
        }

        public void draw(float[] objCentroid) // draw the face with the given centroid
        {
            //GL.Begin(PrimitiveType.Polygon);
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(color);
            foreach (float[] vertex in vertices)
            {
                GL.Vertex3(objCentroid[0] + vertex[0], objCentroid[1] + vertex[1], objCentroid[2] + vertex[2]);
            }
            GL.End();
        }

        public void addVertex(float[] vertex)
        {
            vertices.Add(vertex);
        }

        public void removeVertex(float[] vertex)
        {
            vertices.Remove(vertex);
        }

        public List<float[]> getVertices()
        {
            return vertices;
        }
    }
}
