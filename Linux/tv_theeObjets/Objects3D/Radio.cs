using OpenTK.Graphics;
using System.Collections.Generic;

namespace ConsoleApp1{
    public static class Radio // clase 
    {
        public static List<Face> GetFaces() // método que devuelve una lista de caras que representan una radio
        {
            List<Face> faces = new List<Face>(); // lista de caras

           // Marco frontal de la Radio   
            Face marcoDelanteroRadio = new Face(Color4.Orange); // cara
            marcoDelanteroRadio.addVertex(new float[3] { -0.7f, -0.4f, 0.5f }); // vértice 1
            marcoDelanteroRadio.addVertex(new float[3] { 0.7f, -0.4f, 0.5f });  // vértice 2
            marcoDelanteroRadio.addVertex(new float[3] { 0.7f, 0.4f, 0.5f });   // vértice 3
            marcoDelanteroRadio.addVertex(new float[3] { -0.7f, 0.4f, 0.5f });  // vértice 4
            faces.Add(marcoDelanteroRadio); // añadir la cara a la lista de caras
                
            // Marco trasero de la Radio
            Face marcoAtrasRadio = new Face(Color4.Gray); // cara
            marcoAtrasRadio.addVertex(new float[3] { -0.7f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 1
            marcoAtrasRadio.addVertex(new float[3] { 0.7f + 0.1f, -0.4f + 0.05f, -0.5f });  // vértice 2
            marcoAtrasRadio.addVertex(new float[3] { 0.7f + 0.1f, 0.4f + 0.05f, -0.5f });   // vértice 3
            marcoAtrasRadio.addVertex(new float[3] { -0.7f + 0.1f, 0.4f + 0.05f, -0.5f });  // vértice 4
            faces.Add(marcoAtrasRadio); // añadir la cara a la lista de caras

                // Tapa derecha de la Radio
                Face derechoRadio = new Face(Color4.Lime); // cara
                derechoRadio.addVertex(new float[3] { 0.5f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 1
                derechoRadio.addVertex(new float[3] { 0.5f, -0.4f, 0.5f }); // vértice 2
                derechoRadio.addVertex(new float[3] { 0.5f, 0.4f, 0.5f }); // vértice 3
                derechoRadio.addVertex(new float[3] { 0.5f + 0.1f, 0.4f + 0.05f, -0.5f }); // vértice 4
                faces.Add(derechoRadio); // añadir la cara a la lista de caras

                // Tapa izquierda de la Radio
                Face izquierdoRadio = new Face(Color4.Yellow); // cara
                izquierdoRadio.addVertex(new float[3] { -0.5f, -0.4f, 0.5f }); // vértice 1
                izquierdoRadio.addVertex(new float[3] { -0.5f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 2
                izquierdoRadio.addVertex(new float[3] { -0.5f + 0.1f, 0.4f + 0.05f, -0.5f });  // vértice 3
                izquierdoRadio.addVertex(new float[3] { -0.5f, 0.4f, 0.5f });  // vértice 4
                faces.Add(izquierdoRadio); // añadir la cara a la lista de caras

                // Tapa superior de la Radio
Face tapaSuperiorRadio = new Face(Color4.Magenta); // cara
tapaSuperiorRadio.addVertex(new float[3] { -0.7f, 0.4f, 0.5f });  // vértice 1
tapaSuperiorRadio.addVertex(new float[3] { 0.7f, 0.4f, 0.5f });   // vértice 2
tapaSuperiorRadio.addVertex(new float[3] { 0.7f + 0.1f, 0.4f + 0.05f, -0.5f }); // vértice 3
tapaSuperiorRadio.addVertex(new float[3] { -0.7f + 0.1f, 0.4f + 0.05f, -0.5f });  // vértice 4
faces.Add(tapaSuperiorRadio); // añadir la cara a la lista de caras

                // Tapa inferior de la Radio
Face tapaInferiorRadio = new Face(Color4.Red); // cara
tapaInferiorRadio.addVertex(new float[3] { -0.7f, -0.4f, 0.5f }); // vértice 1
tapaInferiorRadio.addVertex(new float[3] { 0.7f, -0.4f, 0.5f }); // vértice 2
tapaInferiorRadio.addVertex(new float[3] { 0.7f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 3
tapaInferiorRadio.addVertex(new float[3] { -0.7f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 4
faces.Add(tapaInferiorRadio); // añadir la cara a la lista de caras

                //  Antenas parte superior 
float midX = (0.5f + (-0.5f + 0.1f)) / 2;
float midY = 0.4f + 0.05f;
float midZ = (0.5f + (-0.5f)) / 2;

// Antena izquierda
Face antenaIzquierda = new Face(Color4.Gray); // cara
antenaIzquierda.addVertex(new float[3] { midX - 0.2f, midY, midZ }); // vértice 1
antenaIzquierda.addVertex(new float[3] { midX - 0.2f, midY + 0.4f, midZ }); // vértice 2
faces.Add(antenaIzquierda); // añadir la cara a la lista de caras

// Antena derecha
Face antenaDerecha = new Face(Color4.Gray); // cara
antenaDerecha.addVertex(new float[3] { midX + 0.2f, midY, midZ }); // vértice 1
antenaDerecha.addVertex(new float[3] { midX + 0.2f, midY + 0.4f, midZ }); // vértice 2
faces.Add(antenaDerecha); // añadir la cara a la lista de caras


               // Marco de vidrio de la Radio
Face marco1Radio = new Face(Color4.Gray); // cara
marco1Radio.addVertex(new float[3] { -0.39f + 0.1f + 0.1f, 0.13f, 0.7f }); // vértice 1
marco1Radio.addVertex(new float[3] { 0.39f + 0.1f + 0.1f, 0.13f, 0.7f }); // vértice 2
marco1Radio.addVertex(new float[3] { 0.39f + 0.1f + 0.1f, 0.35f, 0.7f }); // vértice 3
marco1Radio.addVertex(new float[3] { -0.39f + 0.1f + 0.1f, 0.35f, 0.7f }); // vértice 4
faces.Add(marco1Radio); // añadir la cara a la lista de caras


// boton del volumen
int numSegments = 100; // Número de segmentos utilizados para dibujar el botón
float radius = 0.15f; // Radio del botón

float centerY = -0.2f; // Posición y del centro del botón

for (int j = 0; j < numSegments; j++)
{
    float theta1 = 2.0f * (float)Math.PI * j / numSegments; // Ángulo inicial
    float theta2 = 2.0f * (float)Math.PI * (j + 1) / numSegments; // Ángulo final

    // Crear una cara para el segmento del botón
    Face boton = new Face(Color4.Blue); // cara
    boton.addVertex(new float[3] { -0.2f, centerY, 0.25f }); // Centro del botón
    boton.addVertex(new float[3] { -0.2f + radius * (float)Math.Cos(theta1), centerY + radius * (float)Math.Sin(theta1), 0.25f }); // Punto inicial en la circunferencia del botón
    boton.addVertex(new float[3] { -0.2f + radius * (float)Math.Cos(theta2), centerY + radius * (float)Math.Sin(theta2), 0.25f }); // Punto final en la circunferencia del botón
    faces.Add(boton); // añadir la cara a la lista de caras
}






                return faces; // devolver la lista de caras
        }
    }
}      