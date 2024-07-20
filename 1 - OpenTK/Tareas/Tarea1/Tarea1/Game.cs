using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1
{
    internal class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { } // constructor

        protected override void OnUpdateFrame(FrameEventArgs e) // override de la clase GameWindow para actualizar el marco
        {
            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e) // override de la clase GameWindow para renderizar el marco
        {
            base.OnRenderFrame(e);
        }

        protected override void OnLoad(EventArgs e) // override de la clase GameWindow para cargar el juego
        {
            base.OnLoad(e);
        }

        protected override void OnUnload(EventArgs e) // override de la clase GameWindow para descargar el juego
        {
            base.OnUnload(e);
        }
    }
}
