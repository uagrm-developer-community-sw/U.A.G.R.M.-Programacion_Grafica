using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1
{
    class Game : GameWindow
    {
        

        private Figure fig; // instancia de la clase Figure
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) // constructor de la clase Game con parametros de ancho, alto y titulo
        { 
            fig = new Figure(); // inicializar la instancia de la clase Figure
        }

        protected override void OnUpdateFrame(FrameEventArgs e) // override de la clase GameWindow para actualizar el marco
        {
            KeyboardState input = OpenTK.Input.Keyboard.GetState(); // obtener el estado del teclado
            if (input.IsKeyDown(Key.Escape)) ; // si se presiona la tecla escape
            {
                Exit(); // salir del juego
            }
        }

        protected override void OnLoad(EventArgs e) // override de la clase GameWindow para cargar el juego
        {
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e) // override de la clase GameWindow para renderizar el marco
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); // limpiar el buffer de color y el buffer de profundidad
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f); // color de fondo blanco

            GL.MatrixMode(MatrixMode.Projection); // establecer el modo de matriz a proyeccion (para la matriz de proyeccion)
            GL.LoadIdentity(); // cargar la matriz identidad
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, -1.0, 1.0); // establecer la matriz de proyeccion (ortogonal) con los parametros (-1.0, 1.0, -1.0, 1.0, -1.0, 1.0)

            fig.letra(); // dibujar el televisor

            Context.SwapBuffers(); // intercambiar los buffers

        }

        protected override void OnResize(EventArgs e) // override de la clase GameWindow para redimensionar la ventana
        {
            GL.Viewport(0, 0, Width, Height); // establecer el viewport con los parametros (0, 0, Width, Height)
            base.OnResize(e);
            
        }

        

        protected override void OnUnload(EventArgs e) // override de la clase GameWindow para descargar el juego
        {
            base.OnUnload(e);
        }
    }
}
