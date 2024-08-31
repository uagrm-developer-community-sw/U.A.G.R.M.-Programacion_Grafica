using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    internal class Game : GameWindow // Clase de juego que hereda de la clase Ventana de juego
    {
        Stage stage; // etapa de juego que contiene los objetos 3D a dibujar en la ventana de juego

        public Game(int width, int height, string title) : base(width, height, OpenTK.Graphics.GraphicsMode.Default, title) { } // constructor

        protected override void OnLoad(EventArgs e) // método que se llama cuando se carga la ventana
        {
            base.OnLoad(e); // llama al método de la clase base
            //GL.ClearColor(0.2f, 0.5f, 0.5f, 0.5f);
            GL.ClearColor(Color4.Black);
            //GL.Enable(EnableCap.DepthTest);

            stage = new Stage(); // crear una nueva etapa
                                 
            Object T = new Object(new float[3] { 0f, 0f, 0f }, LetraT.GetFaces()); // Crea un nuevo objeto con el centroide y las caras de la letra T.

            stage.addObject(T); // Agrega el objeto a la etapa de juego
        }

        protected override void OnRenderFrame(FrameEventArgs e) // método que se llama cuando se renderiza un fotograma de la ventana de juego
        {
        
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); // limpia el búfer de color y el búfer de profundidad
            //GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity(); // carga la matriz de identidad
            GL.Rotate(10.0, 1.0, 0.0, 0.0); // rota la matriz de modelo-vista
            GL.Rotate(45.0, 0.0, -1.0, 0.0); // rota la matriz de modelo-vista

            
            stage.draw(); // dibuja el escenario
            Context.SwapBuffers(); // intercambia los búferes de la ventana de juego

            base.OnRenderFrame(e); // llama al método de la clase base
        }

        protected override void OnResize(EventArgs e) // método que se llama cuando se cambia el tamaño de la ventana de juego
        {
            base.OnResize(e); // llama al método de la clase base
            GL.Viewport(0, 0, Width, Height); // establece el tamaño de la ventana de juego
        }

        protected override void OnUnload(EventArgs e) // método que se llama cuando se cierra la ventana de juego
        {
            base.OnUnload(e); // llama al método de la clase base
        }
    }
}