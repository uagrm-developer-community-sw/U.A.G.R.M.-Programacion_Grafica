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
        private Double punto =0;
        public void puntoInc()
        {
            if (punto == 360)
            {
                punto = 0;
            }
            else { 
                punto += 1;
            }
        }

        public static void DibujarCirculo(Double x, Double y, Double z, Double radio, Double rotacionAnguloGra) { 
            GL.PushMatrix(); // guarda la matriz actual
            GL.Translate(x, y, z); // traslada el objeto
            GL.Rotate(rotacionAnguloGra, 0.0, 1.0, 0.0); // rota el objeto

            GL.Begin(PrimitiveType.Polygon); // comienza a dibujar un poligono
            int numSegmentos = 180; // numero de segmentos
            GL.Color4(Color.Aqua); // color del poligono

            for (int i = 0; i < numSegmentos; i++) // ciclo para dibujar el poligono
            {
                Double angulo = 2 * Math.PI * i / numSegmentos; // angulo del segmento
                Double x1 = radio * Math.Cos(angulo); // coordenada x del vertice
                Double y1 = radio * Math.Sin(angulo); // coordenada y del vertice
                GL.Vertex3(x1, y1, 0.0); // dibuja el vertice
            }
            GL.End(); // termina de dibujar el poligono
            GL.PopMatrix(); // recupera la matriz guardada
        }

        public static void dibujarAuto()
        {
            GL.Begin(PrimitiveType.Quads); //vidrio delantero
            GL.Color3(Color.FromArgb(0, 0, 0, 0));
            GL.Vertex3(-0.4f, 0.5f, 1.5f);
            GL.Vertex3(-0.4f, 0.75f, 1.25f);
            GL.Vertex3(-0.2f, 0.75f, 1.25f);
            GL.Vertex3(-0.2f, 0.5f, 1.50f);
            GL.End();
            
            GL.End();
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.FromArgb(51, 170, 204)); //techo
            GL.Vertex3(-0.4, 0.75, 0.75);
            GL.Vertex3(-0.4, 0.75, 1.25);
            GL.Vertex3(-0.2, 0.75, 1.25);
            GL.Vertex3(-0.2, 0.75, 0.75);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //cabina izquierda
            GL.Vertex3(-0.4, 0.75, 1.25);
            GL.Vertex3(-0.4, 0.5, 1.5);
            GL.Vertex3(-0.4, 0.5, 0.50);
            GL.Vertex3(-0.4, 0.75, 0.75);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //cabina derecha
            GL.Vertex3(-0.2, 0.75, 1.25);
            GL.Vertex3(-0.2, 0.5, 1.5);
            GL.Vertex3(-0.2, 0.5, 0.5);
            GL.Vertex3(-0.2, 0.75, 0.75);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //parachoque delantero
            GL.Vertex3(-0.50, 0.5, 1.5); 
            GL.Vertex3(-0.50, 0.2, 1.5);
            GL.Vertex3(-0.10, 0.2, 1.5);
            GL.Vertex3(-0.10, 0.5, 1.5);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //puertas izquierda
            GL.Vertex3(-0.40, 0.5, 1.5);
            GL.Vertex3(-0.40, 0.2, 1.5);
            GL.Vertex3(-0.40, 0.2, 0.5);
            GL.Vertex3(-0.40, 0.5, 0.5);
            GL.End();
            GL.Begin(PrimitiveType.Quads);//puertas atrás
            GL.Vertex3(-0.40f, 0.5f, 0.5f);
            GL.Vertex3(-0.40f, 0.2f, 0.5f);
            GL.Vertex3(-0.20f, 0.2f, 0.5f);
            GL.Vertex3(-0.20f, 0.5f, 0.5f);
            GL.End();
            GL.Begin(PrimitiveType.Quads);//puertas derecha
            GL.Vertex3(-0.20, 0.5, 1.5);
            GL.Vertex3(-0.20, 0.2, 1.5);
            GL.Vertex3(-0.20, 0.2, 0.5);
            GL.Vertex3(-0.20, 0.5, 0.5);
            GL.End();
            DibujarCirculo(-0.41, 0.25, 0.8, 0.15, 90.0); //izquierda trasera
            DibujarCirculo(-0.19, 0.25, 0.8, 0.15, 90.0); //derecha trasera
            DibujarCirculo(-0.19, 0.25, 1.2, 0.15, 90.0); //derecha delantera
            DibujarCirculo(-0.41, 0.25, 1.2, 0.15, 90.0); //rueda izquierda delantera
        }

        public Game(int ancho, int altura, string título) : base(ancho, altura, GraphicsMode.Default, título) { }

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

        // Dibujar
        protected override void OnRenderFrame(FrameEventArgs e)
        {
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
            dibujarAuto(); // dibuja el auto

            //Dibujar la repisa
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.FromArgb(255, 255, 255  )); //plataforma repisa
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
    }
}
