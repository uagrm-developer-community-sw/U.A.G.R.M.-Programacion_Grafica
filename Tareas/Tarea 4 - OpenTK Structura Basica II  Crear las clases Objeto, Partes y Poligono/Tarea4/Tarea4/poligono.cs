using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    internal class poligono
    {
        private List<Vector3d> vertices;

        private Color color { get; set; }

        private Double radius { get; set; }

        public poligono(Color color)
        {
            vertices = new List<Vector3d>();
            this.color = color;
            this.radius = 0;
        }

        public poligono(Color color, Double radius)
        {
            vertices = new List<Vector3d>();
            this.color = color;
            this.radius = radius;
        }

        public void addVertex(Double x, Double y, Double z)
        {
            vertices.Add(new Vector3d(x, y, z));
        }

        public void removeVertice(int index)
        {
            vertices.RemoveAt(index);
        }

        public void draw(Vector3d centro)
        {
            if(radius > 0)
            {
                drawCircle(centro, 90);
            }else
            {
                GL.Begin(PrimitiveType.Polygon);
                GL.Color3(color);
                foreach (Vector3d v in vertices)
                {
                    GL.Vertex3(centro.X + v.X, centro.Y + v.Y, centro.Z + v.Z);
                }
                GL.End();
            }
        }

        public void drawCircle(Vector3d centro, double rotationaAngleDegrees)
        {
            GL.PushMatrix();
            GL.Translate(centro.X, centro.Y, centro.Z);
            GL.Rotate(rotationaAngleDegrees, 0.0, 1.0, 0.0);

            GL.Begin(PrimitiveType.Polygon);
            int numSegments = 100;

            GL.Color4(Color.Yellow);
            
            for (int i = 0; i < numSegments; i++)
            {
                double angle = 2 * Math.PI * i / numSegments;
                double xPos = Math.Cos(angle) * radius;
                double yPos = Math.Sin(angle) * radius;

                GL.Vertex3(xPos, yPos, 0.0);
            }
            GL.End();

            GL.PopMatrix();
        }

        internal void addVertice(float v1, float v2, float v3)
        {
            throw new NotImplementedException();
        }

        internal Vector3d CalcularCentroDeMasa()
        {
            throw new NotImplementedException();
        }
    }
}
