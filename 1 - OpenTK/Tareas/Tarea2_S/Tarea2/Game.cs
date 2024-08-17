using OpenTK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, OpenTK.Graphics.GraphicsMode.Default, title) { } // Constructor de la clase
        // ------------------------------------------------------
        // METODO QUE SE LLAMA AL CARGAR EL PROGRAMA POR PRIMERA VEZ
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        // ------------------------------------------------------
        // METODO QUE SE LLAMA AL ACTUALIZAR EL PROGRAMA
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
        // ------------------------------------------------------
        // METODO QUE SE LLAMA AL DIBUJAR EL PROGRAMA
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
        }
    }
}
