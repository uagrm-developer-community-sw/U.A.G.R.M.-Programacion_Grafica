using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGrafica
{
    internal class Axis
    {
        public Axis()
        {
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(Color.Red); //Eje X
            GL.Vertex3(-20, 0, 0);
            GL.Vertex3(20, 0, 0);

            GL.Color3(Color.Blue); //Eje Y
            GL.Vertex3(0, -20, 0);
            GL.Vertex3(0, 20, 0);

            GL.Color3(Color.Green); //Eje Z
            GL.Vertex3(0, 0, -500);
            GL.Vertex3(0, 0, 500);

            GL.End();
        }
    }
}
