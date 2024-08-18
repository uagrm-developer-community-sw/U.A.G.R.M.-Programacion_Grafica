using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Game : GameWindow
    {
        private Figure figure; // Figura a dibujar
        // ------------------------------------------------------
        // CONSTRUCTOR DE LA CLASE
        public Game(int width, int height, string title) : base(width, height, OpenTK.Graphics.GraphicsMode.Default, title) 
        { 
            figure = new Figure(); // Crea una nueva figura a dibujar
        }
        // ------------------------------------------------------
        // METODO QUE SE LLAMA AL ACTUALIZAR EL PROGRAMA
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            //base.OnUpdateFrame(e); // Llama al metodo de la clase base
            KeyboardState input = Keyboard.GetState(); // Obtiene el estado del teclado
            if (input.IsKeyDown(Key.Escape)) // Si se presiona la tecla escape
            {
                Exit(); // Cierra el programa
            }
        }
        // ------------------------------------------------------
        // METODO QUE SE LLAMA AL CARGAR EL PROGRAMA POR PRIMERA VEZ
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f); // Establece el color de limpieza de la ventana en azul oscuro
            base.OnLoad(e);
        }
        // ------------------------------------------------------
        // METODO QUE SE LLAMA AL DIBUJAR EL PROGRAMA
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); // Limpia el buffer de color y de profundidad
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f); // Establece el color de limpieza de la ventana en blanco

            GL.MatrixMode(MatrixMode.Projection); // Establece la matriz de proyeccion
            GL.LoadIdentity(); // Carga la matriz identidad
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, -1.0, 1.0); // Establece la matriz de proyeccion ortogonal

            figure.dibujarT(); // Dibuja la figura

            Context.SwapBuffers(); // Intercambia los buffers
        }
        // ------------------------------------------------------
        // METODO QUE SE LLAMA AL CAMBIAR EL TAMAÑO DE LA VENTANA
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height); // Establece el viewport de la ventana con el nuevo tamaño de la ventana
            base.OnResize(e); // Llama al metodo de la clase base para redimensionar la ventana
        }
        // ------------------------------------------------------
        // METODO QUE SE LLAMA AL DESCARGAR EL PROGRAMA
        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);
        }
    }
}
