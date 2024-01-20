using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;

namespace Tarea2_OpenTK
{
    internal class game
    {
        private Double theta = 0;
        public void thetaIncrement() // Incrementa el valor de theta
        {
            if (theta < 360) // Si theta es menor a 360, se le suma 0
            {
                theta = 0;
            }
            else // Si theta es mayor a 360, se le suma 1
            {
                theta += 1;
            }
        }
        public static void DibujarCirculo(double x, double y, double z, double radio, double gradosAnguloRotacion) // Dibuja un círculo
        {
            GL.PushMatrix(); // Guarda la matriz actual en la pila
            GL.Translate(x, y, z); // Traslada el objeto a la posición indicada
            GL.Rotate(gradosAnguloRotacion, 0.0, 1.0, 0.0); // Rota el objeto en el eje Y

            GL.Begin(PrimitiveType.Polygon); // Inicia el dibujo de un polígono
            int numeroSegmentos = 180; // Número de segmentos del polígono

            GL.Color4(Color.Yellow); // Color del polígono

            for (int i = 0; i < numeroSegmentos; i++) // Ciclo para dibujar el polígono
            {
                double angulo = 2 * Math.PI * i / numeroSegmentos; // Ángulo del segmento
                double x1 = radio * Math.Cos(angulo); // Coordenada X del vértice
                double y1 = radio * Math.Sin(angulo); // Coordenada Y del vértice
                GL.Vertex3(x1, y1, 0.0); // Dibuja el vértice
            }

        }

        public static void dibujarCoche()
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
            DibujarCirculo(-0.41, 0.25, 0.8, 0.15, 90.0); //izquierda trasera
            DibujarCirculo(-0.19, 0.25, 0.8, 0.15, 90.0); //derecha trasera
            DibujarCirculo(-0.19, 0.25, 1.2, 0.15, 90.0); //derecha delantera
            DibujarCirculo(-0.41, 0.25, 1.2, 0.15, 90.0); //rueda izquierda delantera
        }

        public game(int ancho, int altura, string título) : base(ancho, altura, GraphicsMode.Default, título) // Constructor de la clase
        {
        }
    }
}
