using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Axes3D
    {
        public static void drawAxes()
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color4(Color4.Red);
            GL.Vertex3(0.0f, 0.0f, 0.0f);
            GL.Vertex3(1.0f, 0.0f, 0.0f);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Color4(Color4.LightBlue);
            GL.Vertex3(0.0f, 0.0f, 0.0f);
            GL.Vertex3(0.0f, 1.0f, 0.0f);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Color4(Color4.Black);
            GL.Vertex3(0.0f, 0.0f, 0.0f);
            GL.Vertex3(0.0f, 0.0f, 1.0f);
            GL.End();
        }

    }
    
}
