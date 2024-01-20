using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Objetos_3D
{
    internal class EjeCoord
    {
        public EjeCoord() { 
            GL.Begin(PrimitiveType.Lines); 
            
            // Pintar eje x
            GL.Color3(Color.Red); // eje x
            GL.Vertex3(-20, 0, 0);
            GL.Vertex3(20, 0, 0);

            // Pintar eje y
            GL.Color3(Color.Blue); // eje y
            GL.Vertex3(0, -20, 0);
            GL.Vertex3(0, 20, 0);

            // Pintar eje z
            GL.Color3(Color.Green); // eje z
            GL.Vertex3(0, 0, -500);
            GL.Vertex3(0, 0, 500);

            GL.End();
        }
    }
}
