using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_3D
{
    class Game: GameWindow
    {
        

        private Double punto = 0;
        

        public Game(int ancho, int altura, string título) 
            : base(ancho, altura, GraphicsMode.Default, título) { }

        // Cargar
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // carga el evento
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f ); // color de fondo
            GL.Enable(EnableCap.DepthTest); // habilita el buffer de profundidad
        }

        // Actualizar
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e); // actualiza el frame
            //puntoInc();
        }

        public void puntoInc()
        {
            if (punto == 360)
            {
                punto = 0;
            }
            else
            {
                punto += 1;
            }
        }

        protected override void OnResize(EventArgs e) // resize the window
        {
            Double escala = 5.0; // escala de la ventana
            GL.Viewport(0, 0, Width, Height); // set viewport
            GL.MatrixMode(MatrixMode.Projection); // set projection matrix
            GL.LoadIdentity();  // carga la matriz identidad
            GL.Ortho(-escala, escala, -escala, escala, -escala, escala);//set escala de la ventana
            GL.MatrixMode(MatrixMode.Modelview); // set modelview matrix

            base.OnResize(e); // resize the window
        }

        // Dibujar
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //Dibujar la repisa
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.FromArgb(255, 255, 255)); //plataforma repisa
            GL.Vertex3(-1.0, 0.04, 0.01);
            GL.Vertex3(-1.0, 0.04, 2.0);
            GL.Vertex3(1.0, 0.04, 2.0);
            GL.Vertex3(1.0, 0.04, 0.01);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //repisa lado izq
            GL.Vertex3(-1.0, 0.04, 0.01);
            GL.Vertex3(-1.0, -0.04, 0.01);
            GL.Vertex3(-1.0, -0.04, 2.0);
            GL.Vertex3(-1.0, 0.04, 2.0);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //repisa lado derecho
            GL.Vertex3(1.0, 0.04, 0.01);
            GL.Vertex3(1.0, -0.04, 0.01);
            GL.Vertex3(1.0, -0.04, 2.0);
            GL.Vertex3(1.0, 0.04, 2.0);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //repisa frontal
            GL.Vertex3(-1.0, 0.04, 2.0);
            GL.Vertex3(-1.0, -0.04, 2.0);
            GL.Vertex3(1.0, -0.04, 2.0);
            GL.Vertex3(1.0, 0.04, 2.0);
            GL.End();
            Context.SwapBuffers(); // intercambia los buffers
            base.OnRenderFrame(e); // dibuja el frame


            GL.LoadIdentity(); // carga la matriz identidad
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); // limpia el buffer de color y el buffer de profundidad
            GL.Rotate(10.0, 1.0, 0.0, 0.0); // rota el objeto en el eje x
            GL.Rotate(punto, 0.0, 1.0, 0.0); // rota el objeto en el eje y
            EjeCoord eje = new EjeCoord(); // crea un objeto de la clase EjeCoord

            //Dibujar Pared
            GL.Begin(PrimitiveType.Quads); // comienza a dibujar un cuadrado

            GL.Color3(0.7f, 0.2f, 0.1f); // color del cuadrado
            GL.Vertex3(-2.0f, -2.0f, 0.0f); // vertice 1

            GL.Color3(0.7f, 0.2f, 0.1f); // color del cuadrado
            GL.Vertex3(2.0f, -2.0f, 0.0f); // vertice 2

            GL.Color3(0.7f, 0.2f, 0.1f); // color del cuadrado
            GL.Vertex3(2.0f, 2.0f, 0.0f); // vertice 3


            GL.Vertex3(-2.0f, 2.0f, 0.0f); // vertice 4

            GL.End(); // termina de dibujar el cuadrado
            puntoInc(); // incrementa el punto


            //Dibujar auto
            GL.Begin(PrimitiveType.Quads); // comienza a dibujar un auto
            
            GL.Color3(0.7f, 0.2f, 0.1f); 
            GL.Vertex3(-0.5f, -0.5f, 0.0f);

            GL.Color3(0.7f, 0.2f, 0.1f);
            GL.Vertex3(0.5f, -0.5f, 0.0f);

            GL.Color3(0.7f, 0.2f, 0.1f);

        }
    }
}
