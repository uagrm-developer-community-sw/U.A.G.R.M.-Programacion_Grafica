using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Triangulo_2D
{
    internal class Triangulo_2D
    {
        GameWindow window;
        public Triangulo_2D(GameWindow window)
        {
            this.window = window;
            Start();
        }

        void Start()
        {
            window.Load += Loaded;
            window.Resize += resize;
            window.RenderFrame += renderF;
            window.Run(1.0/60.0);
        }

        void resize(object ob, EventArgs e)
        {
            GL.Viewport(0,0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0.0,50.0,0.0,50.0,-1.0,1.0);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        void renderF(object o, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(BeginMode.Triangles);
            GL.Vertex2(1.0, 1.0);
            GL.Vertex2(49.0,1.0);
            GL.Vertex2(25.0,49.0);
            GL.End();
            window.SwapBuffers();
        }

        void Loaded(object o, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        }
    }
}
