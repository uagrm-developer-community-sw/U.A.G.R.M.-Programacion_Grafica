using OpenTK.Graphics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Tv // clase 
    {
        public static List<Face> GetFaces() // método que devuelve una lista de caras que representan una televisión
        {
            List<Face> faces = new List<Face>(); // lista de caras

            // Marco frontal de la televisión {#e86,6}   
            Face marcoTv = new Face(Color4.Orange); // cara
            marcoTv.addVertex(new float[3] { -0.5f, -0.4f, 0.5f }); // vértice 1
            marcoTv.addVertex(new float[3] { 0.5f, -0.4f, 0.5f });  // vértice 2
            marcoTv.addVertex(new float[3] { 0.5f, 0.4f, 0.5f });   // vértice 3
            marcoTv.addVertex(new float[3] { -0.5f, 0.4f, 0.5f });  // vértice 4
            faces.Add(marcoTv); // añadir la cara a la lista de caras
 
            // Marco trasero de la televisión {#e30,6}
            Face marcoAtrasTv = new Face(Color4.Gray); // cara
            marcoAtrasTv.addVertex(new float[3] { -0.5f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 1
            marcoAtrasTv.addVertex(new float[3] { 0.5f + 0.1f, -0.4f + 0.05f, -0.5f });  // vértice 2
            marcoAtrasTv.addVertex(new float[3] { 0.5f + 0.1f, 0.4f + 0.05f, -0.5f });   // vértice 3
            marcoAtrasTv.addVertex(new float[3] { -0.5f + 0.1f, 0.4f + 0.05f, -0.5f });  // vértice 4
            faces.Add(marcoAtrasTv); // añadir la cara a la lista de caras

            // Tapa derecha de la televisión {#2bd,6}
            Face derechoTv = new Face(Color4.Lime); // cara
            derechoTv.addVertex(new float[3] { 0.5f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 1
            derechoTv.addVertex(new float[3] { 0.5f, -0.4f, 0.5f }); // vértice 2
            derechoTv.addVertex(new float[3] { 0.5f, 0.4f, 0.5f }); // vértice 3
            derechoTv.addVertex(new float[3] { 0.5f + 0.1f, 0.4f + 0.05f, -0.5f }); // vértice 4
            faces.Add(derechoTv); // añadir la cara a la lista de caras

            // Tapa izquierda de la televisión {#c26,6}
            Face izquierdoTv = new Face(Color4.Yellow); // cara
            izquierdoTv.addVertex(new float[3] { -0.5f, -0.4f, 0.5f }); // vértice 1
            izquierdoTv.addVertex(new float[3] { -0.5f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 2
            izquierdoTv.addVertex(new float[3] { -0.5f + 0.1f, 0.4f + 0.05f, -0.5f });  // vértice 3
            izquierdoTv.addVertex(new float[3] { -0.5f, 0.4f, 0.5f });  // vértice 4
            faces.Add(izquierdoTv); // añadir la cara a la lista de caras

            // Tapa superior de la televisión {#582,6}
            Face tapaSuperiorTv = new Face(Color4.Magenta); // cara
            tapaSuperiorTv.addVertex(new float[3] { -0.5f, 0.4f, 0.5f });  // vértice 1
            tapaSuperiorTv.addVertex(new float[3] { 0.5f, 0.4f, 0.5f });   // vértice 2
            tapaSuperiorTv.addVertex(new float[3] { 0.5f + 0.1f, 0.4f + 0.05f, -0.5f }); // vértice 3
            tapaSuperiorTv.addVertex(new float[3] { -0.5f + 0.1f, 0.4f + 0.05f, -0.5f });  // vértice 4
            faces.Add(tapaSuperiorTv); // añadir la cara a la lista de caras

            // Tapa inferior de la televisión {#0ba,6}
            Face tapaInferiorTv = new Face(Color4.Red); // cara
            tapaInferiorTv.addVertex(new float[3] { -0.5f, -0.4f, 0.5f }); // vértice 1
            tapaInferiorTv.addVertex(new float[3] { 0.5f, -0.4f, 0.5f }); // vértice 2
            tapaInferiorTv.addVertex(new float[3] { 0.5f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 3
            tapaInferiorTv.addVertex(new float[3] { -0.5f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 4
            faces.Add(tapaInferiorTv); // añadir la cara a la lista de caras

            //  Antenas parte superior {#a2b,15}
            float midX = (0.5f + (-0.5f + 0.1f)) / 2;
            float midY = 0.4f + 0.05f;
            float midZ = (0.5f + (-0.5f)) / 2;

            // Antena izquierda
            Face antenaIzquierda = new Face(Color4.Gray); // cara
            antenaIzquierda.addVertex(new float[3] { midX, midY, midZ }); // vértice 1
            antenaIzquierda.addVertex(new float[3] { midX - 0.2f, midY + 0.4f, midZ }); // vértice 2
            faces.Add(antenaIzquierda); // añadir la cara a la lista de caras

            // Antena derecha
            Face antenaDerecha = new Face(Color4.Gray); // cara
            antenaDerecha.addVertex(new float[3] { midX, midY, midZ }); // vértice 1
            antenaDerecha.addVertex(new float[3] { midX + 0.2f, midY + 0.4f, midZ }); // vértice 2
            faces.Add(antenaDerecha); // añadir la cara a la lista de caras

            // Marco de vidrio de la televisión {#b64,6}
            Face marcoVidrioTv1 = new Face(Color4.Gray); // cara
            marcoVidrioTv1.addVertex(new float[3] { -0.39f + 0.1f + 0.1f, -0.29f, 0.7f }); // vértice 1
            marcoVidrioTv1.addVertex(new float[3] { 0.39f + 0.1f + 0.1f, -0.29f, 0.7f }); // vértice 2
            marcoVidrioTv1.addVertex(new float[3] { 0.39f + 0.1f + 0.1f, 0.29f, 0.7f }); // vértice 3
            marcoVidrioTv1.addVertex(new float[3] { -0.39f + 0.1f + 0.1f, 0.29f, 0.7f }); // vértice 4
            faces.Add(marcoVidrioTv1); // añadir la cara a la lista de caras
            
            // Botonos de la tv
            int numSegments = 100; // Número de segmentos utilizados para dibujar cada botón
            float radius = 0.05f; // Radio de cada botón
            float buttonSpacing = 0.15f; // Espacio entre los botones

            for (int i = 0; i < 3; i++) 
            {
                float centerY = 0.0f + i * buttonSpacing; // Posición y del centro del botón

                for (int j = 0; j < numSegments; j++)
                {
                    float theta1 = 2.0f * (float)Math.PI * j / numSegments; // Ángulo inicial
                    float theta2 = 2.0f * (float)Math.PI * (j + 1) / numSegments; // Ángulo final

                    // Crear una cara para el segmento del botón
                    Face boton = new Face(Color4.Blue); // cara
                    boton.addVertex(new float[3] { 0.4f, centerY, 0.25f }); // Centro del botón
                    boton.addVertex(new float[3] { 0.4f + radius * (float)Math.Cos(theta1), centerY + radius * (float)Math.Sin(theta1), 0.25f }); // Punto inicial en la circunferencia del botón
                    boton.addVertex(new float[3] { 0.4f + radius * (float)Math.Cos(theta2), centerY + radius * (float)Math.Sin(theta2), 0.25f }); // Punto final en la circunferencia del botón
                    faces.Add(boton); // añadir la cara a la lista de caras
                }
            }

            return faces; // devolver la lista de caras
        }
    }
}