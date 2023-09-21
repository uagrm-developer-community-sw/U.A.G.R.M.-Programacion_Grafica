using OpenTK.Graphics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Floor
    {
        public static List<Face> GetFaces()
        {
            List<Face> faces = new List<Face>();
            Face floor = new Face(Color4.Green);
            floor.addVertex(new float[3] { 0.75f, 0.0f, 0.75f });
            floor.addVertex(new float[3] { -0.75f, 0.0f, 0.75f });
            floor.addVertex(new float[3] { -0.75f, 0.0f, -0.75f });
            floor.addVertex(new float[3] { 0.75f, 0.0f, -0.75f });
            faces.Add(floor);
            return faces;
        }
    }
}
