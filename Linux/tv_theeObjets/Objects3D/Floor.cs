using OpenTK.Graphics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Floor // clase que representa un suelo
    {
        public static List<Face> GetFaces() // método que devuelve una lista de caras que representan un suelo
        {
            List<Face> faces = new List<Face>(); // lista de caras
            Face floor = new Face(Color4.Green); // cara del suelo
            floor.addVertex(new float[3] { 0.75f, 0.0f, 0.75f }); // vértice 1
            floor.addVertex(new float[3] { -0.75f, 0.0f, 0.75f }); // vértice 2
            floor.addVertex(new float[3] { -0.75f, 0.0f, -0.75f }); // vértice 3
            floor.addVertex(new float[3] { 0.75f, 0.0f, -0.75f }); // vértice 4
            faces.Add(floor); // añadir la cara a la lista de caras
            return faces; // devolver la lista de caras
        }
    }
}
