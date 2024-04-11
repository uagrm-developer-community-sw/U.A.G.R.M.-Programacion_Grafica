using OpenTK.Graphics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class House // clase que representa una casa
    {
        public static List<Face> GetFaces() // método que devuelve una lista de caras que representan una casa
        {
            List<Face> faces = new List<Face>(); // lista de caras

            Face leftWall = new Face(Color4.LightGray); // cara izquierda
            leftWall.addVertex(new float[3] { -0.2f, 0.0f, 0.3f }); // vértice 1
            leftWall.addVertex(new float[3] { -0.2f, 0.2f, 0.3f});  // vértice 2
            leftWall.addVertex(new float[3] { -0.2f, 0.2f, -0.3f }); // vértice 3
            leftWall.addVertex(new float[3] { -0.2f, 0.0f, -0.3f }); // vértice 4
            faces.Add(leftWall); // añadir la cara a la lista de caras

            Face rightWall = new Face(Color4.LightSalmon); // cara derecha
            rightWall.addVertex(new float[3] { 0.2f, 0.0f, 0.3f }); // vértice 1
            rightWall.addVertex(new float[3] { 0.2f, 0.2f, 0.3f }); // vértice 2
            rightWall.addVertex(new float[3] { 0.2f, 0.2f, -0.3f }); // vértice 3
            rightWall.addVertex(new float[3] { 0.2f, 0.0f, -0.3f }); // vértice 4
            faces.Add(rightWall); // añadir la cara a la lista de caras

            Face frontWall = new Face(Color4.Blue); // cara frontal
            frontWall.addVertex(new float[3] { 0.2f, 0.0f, 0.3f }); // vértice 1
            frontWall.addVertex(new float[3] { -0.2f, 0.0f, 0.3f }); // vértice 2
            frontWall.addVertex(new float[3] { -0.2f, 0.2f, 0.3f }); // vértice 3
            frontWall.addVertex(new float[3] { 0.2f, 0.2f, 0.3f }); // vértice 4
            faces.Add(frontWall); // añadir la cara a la lista de caras

            Face backWall = new Face(Color4.LightGray); // cara trasera
            backWall.addVertex(new float[3] { 0.2f, 0.0f, -0.3f }); // vértice 1
            backWall.addVertex(new float[3] { -0.2f, 0.0f, -0.3f }); // vértice 2
            backWall.addVertex(new float[3] { -0.2f, 0.2f, -0.3f }); // vértice 3
            backWall.addVertex(new float[3] { 0.2f, 0.2f, -0.3f }); // vértice 4
            faces.Add(backWall); // añadir la cara a la lista de caras

            Face frontAtticWall = new Face(Color4.DarkBlue); // cara frontal del ático
            frontAtticWall.addVertex(new float[3] { 0.2f, 0.2f, 0.3f }); // vértice 1
            frontAtticWall.addVertex(new float[3] { -0.2f, 0.2f, 0.3f }); // vértice 2
            frontAtticWall.addVertex(new float[3] { 0.0f, 0.35f, 0.3f }); // vértice 3
            faces.Add(frontAtticWall); // añadir la cara a la lista de caras

            Face backAtticWall = new Face(Color4.DarkGray); // cara trasera del ático
            backAtticWall.addVertex(new float[3] { 0.2f, 0.2f, -0.3f }); // vértice 1
            backAtticWall.addVertex(new float[3] { -0.2f, 0.2f, -0.3f }); // vértice 2
            backAtticWall.addVertex(new float[3] { 0.0f, 0.35f, -0.3f }); // vértice 3
            faces.Add(backAtticWall); // añadir la cara a la lista de caras

            Face leftRoof = new Face(Color4.Orange); // cara izquierda del tejado
            leftRoof.addVertex(new float[3] { -0.2f, 0.2f, 0.3f }); // vértice 1
            leftRoof.addVertex(new float[3] { -0.2f, 0.2f, -0.3f }); // vértice 2
            leftRoof.addVertex(new float[3] { 0.0f, 0.35f, -0.3f }); // vértice 3
            leftRoof.addVertex(new float[3] { 0.0f, 0.35f, 0.3f }); // vértice 4
            faces.Add(leftRoof); // añadir la cara a la lista de caras

            Face rightRoof = new Face(Color4.Orange);   // cara derecha del tejado
            leftRoof.addVertex(new float[3] { 0.2f, 0.2f, 0.3f }); // vértice 1
            leftRoof.addVertex(new float[3] { 0.2f, 0.2f, -0.3f }); // vértice 2
            leftRoof.addVertex(new float[3] { 0.0f, 0.35f, -0.3f }); // vértice 3
            leftRoof.addVertex(new float[3] { 0.0f, 0.35f, 0.3f }); // vértice 4
            faces.Add(leftRoof); // añadir la cara a la lista de caras

            Face door = new Face(Color4.Brown); // cara de la puerta
            door.addVertex(new float[3] { 0.05f, 0.0f, 0.3f }); // vértice 1
            door.addVertex(new float[3] { -0.05f, 0.0f, 0.3f }); // vértice 2
            door.addVertex(new float[3] { -0.05f, 0.1f, 0.3f }); // vértice 3
            door.addVertex(new float[3] { 0.05f, 0.1f, 0.3f }); // vértice 4
            faces.Add(door); // añadir la cara a la lista de caras

            return faces; // devolver la lista de caras
        }
    }
}
