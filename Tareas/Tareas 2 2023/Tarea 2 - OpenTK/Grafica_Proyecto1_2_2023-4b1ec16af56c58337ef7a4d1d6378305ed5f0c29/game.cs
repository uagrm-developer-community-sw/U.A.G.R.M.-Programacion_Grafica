using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace ProGrafica
{
    class game:GameWindow
    {
        private Double theta = 0;
        public void thetaInc()
        {
            if (theta == 360)
            {
                theta = 0;
            }
            else
            {
                theta += 1;
            }
        }
        public static void DrawCircle(double x, double y, double z, double radius, double rotationAngleDegrees)
        {
            GL.PushMatrix(); // Save the current modelview matrix
            GL.Translate(x, y, z); // Translate to the circle's position
            GL.Rotate(rotationAngleDegrees, 0.0, 1.0, 0.0); // Apply the rotation to the circle

            GL.Begin(PrimitiveType.Polygon);
            int numSegments = 180;

            GL.Color4(Color.Yellow);

            for (int i = 0; i < numSegments; i++)
            {
                double angle = 2 * Math.PI * i / numSegments;
                double xPos = radius * Math.Cos(angle);
                double yPos = radius * Math.Sin(angle);

                GL.Vertex3(xPos, yPos, 0.0);
            }

            GL.End();

            GL.PopMatrix(); // Restore the previous modelview matrix
        }
        public static void DrawCar()
        {
            GL.Begin(PrimitiveType.Quads); //vidrio delantero
                GL.Color3(Color.FromArgb(1, 168, 204, 215));
                GL.Vertex3(-0.4f, 0.5f, 1.5f);
                GL.Vertex3(-0.4f, 0.75f, 1.25f);
                GL.Vertex3(-0.2f, 0.75f, 1.25f);
                GL.Vertex3(-0.2f, 0.5f, 1.50f);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //vidrio trasero
                GL.Vertex3(-0.4, 0.75, 0.75);
                GL.Vertex3(-0.4, 0.5, 0.5);
                GL.Vertex3(-0.2, 0.5, 0.5);
                GL.Vertex3(-0.2, 0.75, 0.75);
            GL.End();
            GL.Begin(PrimitiveType.Quads);
                GL.Color3(Color.FromArgb(1, 170, 51, 51)); //techo
                GL.Vertex3(-0.4, 0.75, 0.75);
                GL.Vertex3(-0.4, 0.75, 1.25);
                GL.Vertex3(-0.2, 0.75, 1.25);
                GL.Vertex3(-0.2, 0.75, 0.75);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //cabina izq
                GL.Vertex3(-0.4, 0.75, 1.25);
                GL.Vertex3(-0.4, 0.5, 1.5);
                GL.Vertex3(-0.4, 0.5, 0.50);
                GL.Vertex3(-0.4, 0.75, 0.75);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //cabina der
                GL.Vertex3(-0.2, 0.75, 1.25);
                GL.Vertex3(-0.2, 0.5, 1.5);
                GL.Vertex3(-0.2, 0.5, 0.5);
                GL.Vertex3(-0.2, 0.75, 0.75);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //parachoque delantero
                GL.Vertex3(-0.40, 0.5, 1.5);
                GL.Vertex3(-0.40, 0.2, 1.5);
                GL.Vertex3(-0.20, 0.2, 1.5);
                GL.Vertex3(-0.20, 0.5, 1.5);
            GL.End();
            GL.Begin(PrimitiveType.Quads); //puertas izq
                GL.Vertex3(-0.40, 0.5, 1.5);
                GL.Vertex3(-0.40, 0.2, 1.5);
                GL.Vertex3(-0.40, 0.2, 0.5);
                GL.Vertex3(-0.40, 0.5, 0.5);
            GL.End();
            GL.Begin(PrimitiveType.Quads);//puertas back
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
            DrawCircle(-0.41, 0.25, 0.8, 0.15, 90.0); //izquierda trasera
            DrawCircle(-0.19, 0.25, 0.8, 0.15, 90.0); //derecha trasera
            DrawCircle(-0.19, 0.25, 1.2, 0.15, 90.0); //derecha delantera
            DrawCircle(-0.41, 0.25, 1.2, 0.15, 90.0); //rueda izquierda delantera
        }
        public game(int widht, int height, string title):base(widht, height, GraphicsMode.Default, title)
        {
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            //Code goes here
            GL.Enable(EnableCap.DepthTest);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); //wea de la doc

            GL.Rotate(10.0, 1.0, 0.0, 0.0); //rotar 10 grados en x
            GL.Rotate(theta, 0.0, 1.0, 0.0); //rotar theta grados en y
            Axis axis = new Axis();

            //Dibujo de la pared
            GL.Begin(PrimitiveType.Quads); //Se informa que forma estará dibujando para saber en q orden
                                            //trazar las lineas entre puntos

                GL.Color3(1.0f, 0.0f, 0.0f); //Color, es necesario pasar almenos una declaracion de color
                GL.Vertex3(-2.0f, -2.0f, 0.0f); //Punto 1, Visto desde un cuadrado, es el de la izquierda
                                             //abajo

                GL.Color3(0.0f, 1.0f, 0.0f);
                GL.Vertex3(2.0f, -2.0f,0.0f);//Punto 2, ezquina inferior derecha

                GL.Color3(0.0f, 0.0f, 1.0f);
                GL.Vertex3(2.0f, 2.0f, 0.0f); //Punto 3, ezquina superior derecha
            
                GL.Vertex3(-2.0f,2.0f,0.0f); 

            GL.End();
            thetaInc();
            DrawCar();

            //Dibujar la repisa
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.FromArgb(101, 56, 24)); //plataforma repisa
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
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            Double escala = 5.0;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-escala, escala, -escala, escala, -escala, escala);//set escala
            GL.MatrixMode(MatrixMode.Modelview);


            base.OnResize(e);
        }
    }
}
