using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor_OpenTK
{
    class Game : GameWindow
    {
        private Figure fig; // This is the only change in this file

        public Game(int width, int height, string title) : base(width, height, OpenTK.Graphics.GraphicsMode.Default, title) // constructor
        {
            fig = new Figure(); // This is the only change in this file
        }

        protected override void OnUpdateFrame(FrameEventArgs e) // update frame
        {
            KeyboardState input = OpenTK.Input.Keyboard.GetState(); // get keyboard state to check for input
            if (input.IsKeyDown(Key.Escape)) // if the escape key is pressed
            {
                Exit(); // exit the game
            }
        }

        protected override void OnLoad(EventArgs e) // load event 
        {
            base.OnLoad(e); // call the base class's OnLoad method
        }

        protected override void OnRenderFrame(FrameEventArgs e) //
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); // clear the color and depth buffer
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f); // Blanco sin transparencia

            GL.MatrixMode(MatrixMode.Projection); // set the matrix mode to projection
            GL.LoadIdentity(); // load the identity matrix
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, -1.0, 1.0); // set the orthographic projection

            fig.dibujarTv();

            Context.SwapBuffers(); // swap the front and back buffer

            
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height); // set the viewport to the size of the window
            base.OnResize(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);
        }
    }
}
