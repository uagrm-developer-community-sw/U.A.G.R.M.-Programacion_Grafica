using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor_OpenTK
{
    class Figure
    {
        // Dibuja un televisor en la posición actual
        public void dibujarTv() 
        {
            // Tapas de la caja
            marcoAtrasTv();
            izquierdoTv();
            tapaSuperiorTv();
            tapaInferiorTv();
            derechoTv();
            marcoTv();

            // Complemento
            botonesTv();
            antenasTv();
            marcoVidrioTv1();

            //marcoVidrioTv();
        }

        // Parte delantera de la caja
        private void marcoTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(1.0f, 0.5f, 0.0f); // Color naranja chillón
            
            GL.Vertex3(-0.5f, -0.4f, 0.5f); // Esquina inferior izquierda
            GL.Vertex3(0.5f, -0.4f, 0.5f);  // Esquina inferior derecha *
            GL.Vertex3(0.5f, 0.4f, 0.5f);   // Esquina superior derecha
            GL.Vertex3(-0.5f, 0.4f, 0.5f);  // Esquina superior izquierda

            GL.End();
        }

        // Parte trasera de la caja
        private void marcoAtrasTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(0.1f, 0.1f, 0.1f); // Color del marco (gris oscuro)

            GL.Vertex3(-0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior izquierda
            GL.Vertex3(0.5f + 0.1f, -0.4f + 0.05f, -0.5f);  // Esquina inferior derecha 
            GL.Vertex3(0.5f + 0.1f, 0.4f + 0.05f, -0.5f);   // Esquina superior derecha 1
            GL.Vertex3(-0.5f + 0.1f, 0.4f + 0.05f, -0.5f);  // Esquina superior izquierda

            GL.End();
        }

        // Lateral derecho de la caja
        private void derechoTv()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde chillón

            GL.Vertex3(0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior trasera
            GL.Vertex3(0.5f, -0.4f, 0.5f); // Esquina inferior delantera
            GL.Vertex3(0.5f, 0.4f, 0.5f); // Esquina superior delantera 2
            GL.Vertex3(0.5f + 0.1f, 0.4f + 0.05f, -0.5f); // Esquina superior trasera 1

            GL.End();
        }

        // Lado izquierdo de la caja
        private void izquierdoTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(1.0f, 1.0f, 0.0f); // Color amarillo chillón

            GL.Vertex3(-0.5f, -0.4f, 0.5f); // Esquina inferior delantera
            GL.Vertex3(-0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior trasera
            GL.Vertex3(-0.5f + 0.1f, 0.4f + 0.05f, -0.5f);  // Esquina superior trasera
            GL.Vertex3(-0.5f, 0.4f, 0.5f);  // Esquina superior delantera

            GL.End();
        }

        // Tapa superior de la caja
        private void tapaSuperiorTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(1.0f, 0.0f, 1.0f); // Color naranja chillón

            GL.Vertex3(-0.5f, 0.4f, 0.5f);  // Esquina superior izquierda delantera
            GL.Vertex3(0.5f, 0.4f, 0.5f);   // Esquina superior derecha delantera
            GL.Vertex3(0.5f + 0.1f, 0.4f + 0.05f, -0.5f); // Esquina superior derecha trasera
            GL.Vertex3(-0.5f + 0.1f, 0.4f + 0.05f, -0.5f);  // Esquina superior izquierda trasera

            GL.End();
        }

        // Tapa inferior de la caja
        private void tapaInferiorTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo chillón

            GL.Vertex3(-0.5f, -0.4f, 0.5f); // Esquina inferior izquierda delantera
            GL.Vertex3(0.5f, -0.4f, 0.5f); // Esquina inferior derecha delantera
            GL.Vertex3(0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior derecha trasera
            GL.Vertex3(-0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior izquierda trasera

            GL.End();
        }

        //----------------------------------------------------------------------------
        // Antenas en forma de V
        private void antenasTv()
        {
            GL.LineWidth(3.0f); // Hace las líneas más gruesas

            GL.Begin(PrimitiveType.Lines); // Dibuja líneas

            GL.Color3(0.1f, 0.1f, 0.1f); // Color de la base (gris oscuro)

            // Punto medio de la tapa superior
            float midX = (0.5f + (-0.5f + 0.1f)) / 2;
            float midY = 0.4f + 0.05f;
            float midZ = (0.5f + (-0.5f)) / 2;

            // Antena izquierda
            GL.Vertex3(midX, midY, midZ); // Punto medio
            GL.Vertex3(midX - 0.2f, midY + 0.4f, midZ); // Punto final, más largo

            // Antena derecha
            GL.Vertex3(midX, midY, midZ); // Punto medio
            GL.Vertex3(midX + 0.2f, midY + 0.4f, midZ); // Punto final, más largo

            GL.End();
        }


        // Marco de vidrio en la parte delantera del televisor
        private void marcoVidrioTv1()
        {
            GL.Color3(0.1f, 0.1f, 0.1f); // Color de la base (gris oscuro)

            // Dibuja el cuadrilátero central
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex3(-0.39f, -0.29f, 0.7f); // Esquina inferior izquierda
            GL.Vertex3(0.29f, -0.29f, 0.7f); // Esquina inferior derecha
            GL.Vertex3(0.29f, 0.29f, 0.5f); // Esquina superior derecha
            GL.Vertex3(-0.39f, 0.29f, 0.5f); // Esquina superior izquierda
            GL.End();

            // Dibuja los círculos en las esquinas
            float radius = 0.05f;
            int numSegments = 100;
            for (int i = 0; i < 4; i++)
            {
                float centerX = (i % 2 == 0) ? -0.35f : 0.25f;
                float centerY = (i < 2) ? -0.25f : 0.25f;
                GL.Begin(PrimitiveType.TriangleFan);
                GL.Vertex3(centerX, centerY, 0.5f);
                for (int j = 0; j <= numSegments; j++)
                {
                    float theta = 2.0f * (float)Math.PI * j / numSegments;
                    float dx = radius * (float)Math.Cos(theta);
                    float dy = radius * (float)Math.Sin(theta);
                    GL.Vertex3(centerX + dx, centerY + dy, 0.5f);
                }
                GL.End();
            }
        }

        // Botones del televisor
        private void botonesTv()
        {
            int numSegments = 100; // Número de segmentos utilizados para dibujar cada botón
            float radius = 0.05f; // Radio de cada botón
            float buttonSpacing = 0.15f; // Espacio entre los botones

            GL.Color3(0.0f, 0.0f, 1.0f); // Color azul chillón

            for (int i = 0; i < 3; i++) 
            {
                GL.Begin(PrimitiveType.TriangleFan); // 

                float centerY = 0.0f + i * buttonSpacing; // Posición y del centro del botón

                GL.Vertex3(0.4f, centerY, 0.25f); // Centro del botón

                for (int j = 0; j <= numSegments; j++)
                {
                    float theta = 2.0f * (float)Math.PI * j / numSegments; // Ángulo actual
                    float dx = radius * (float)Math.Cos(theta);
                    float dy = radius * (float)Math.Sin(theta);
                    GL.Vertex3(0.4f + dx, centerY + dy, 0.25f); // Punto en la circunferencia del botón
                }

                GL.End();
            }
        }

        // Marco de la parte delantera del televisor
        private void marcoVidrioTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(0.1f, 0.1f, 0.1f); // Color de la base (gris oscuro)
            
            GL.Vertex3(-0.4f, -0.3f, 0.5f); // Esquina inferior izquierda
            GL.Vertex3(0.3f, -0.3f, 0.5f);  // Esquina inferior derecha *
            GL.Vertex3(0.3f, 0.3f, 0.5f);   // Esquina superior derecha
            GL.Vertex3(-0.4f, 0.3f, 0.5f);  // Esquina superior izquierda

            GL.End();
        }
    }
}