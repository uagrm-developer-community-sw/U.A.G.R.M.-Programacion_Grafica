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

        public Face()
        {
            vertices = new List<float[]>(); 
        }

        public Face(Color4 color) : this()
        {
            this.color = color;
        }

        public void setColor(Color4 color)
        {
            this.color = color;
        }

        public void draw(float[] objCentroid)
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
