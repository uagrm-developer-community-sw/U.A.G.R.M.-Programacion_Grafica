using OpenTK.Graphics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Florero // clase 
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
 
            // Marco trasero de la televisión {#e30,10}
            Face marcoAtrasTv = new Face(Color4.Gray); // cara
            marcoAtrasTv.addVertex(new float[3] { -0.5f + 0.1f, -0.4f + 0.05f, -0.5f }); // vértice 1
            marcoAtrasTv.addVertex(new float[3] { 0.5f + 0.1f, -0.4f + 0.05f, -0.5f });  // vértice 2
            marcoAtrasTv.addVertex(new float[3] { 0.5f + 0.1f, 0.4f + 0.05f, -0.5f });   // vértice 3
            marcoAtrasTv.addVertex(new float[3] { -0.5f + 0.1f, 0.4f + 0.05f, -0.5f });  //
            faces.Add(marcoAtrasTv); // añadir la cara a la lista de caras
            
            
            return faces; // devolver la lista de caras
        }       
    }
}