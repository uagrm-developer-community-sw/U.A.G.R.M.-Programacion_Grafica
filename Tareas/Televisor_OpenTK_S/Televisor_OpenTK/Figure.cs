using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor_OpenTK
{
    class Figure
    {
        public void dibujarTv()
        {
            // Draw the TV
            cuerpoTv();
            pantallaTv();
            SoporteTv();
        }

        public void cuerpoTv()
        {
            // Dibujar el cuerpo de la TV (color marrón)
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(0.545f, 0.271f, 0.075f, 1f); // Marrón (en formato RGBA)
            GL.Vertex3(-1f, -0.7f, 0.5f);
            GL.Vertex3(1f, -0.7f, 0.5f);
            GL.Vertex3(1f, 0.7f, 0.5f);
            GL.Vertex3(-1f, 0.7f, 0.5f);
            GL.End();
        }

        public void pantallaTv()
        {
            // Dibujar la pantalla de la
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(0f, 0f, 0f, 1f); // Negro (en formato RGBA)
            GL.Vertex3(-0.8f, -0.6f, 0.51f);
            GL.Vertex3(0.8f, -0.6f, 0.51f);
            GL.Vertex3(0.8f, 0.6f, 0.51f);
            GL.Vertex3(-0.8f, 0.6f, 0.51f);
            GL.End();
        }

        public void SoporteTv()
        {
            // Dibujar el soporte de la TV (color gris)
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(0.5f, 0.5f, 0.5f, 1f); // Gris (en formato RGBA)
            GL.Vertex3(-0.1f, -0.7f, -0.5f);
            GL.Vertex3(0.1f, -0.7f, -0.5f);
            GL.Vertex3(0.1f, -0.5f, -0.5f);
            GL.Vertex3(-0.1f, -0.5f, -0.5f);
            GL.End();
        }
    }
}
