using OpenTK.Graphics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class House
    {
        public static List<Face> GetFaces()
        {
            List<Face> faces = new List<Face>();

            Face leftWall = new Face(Color4.LightGray);
            leftWall.addVertex(new float[3] { -0.2f, 0.0f, 0.3f });
            leftWall.addVertex(new float[3] { -0.2f, 0.2f, 0.3f});
            leftWall.addVertex(new float[3] { -0.2f, 0.2f, -0.3f });
            leftWall.addVertex(new float[3] { -0.2f, 0.0f, -0.3f });
            faces.Add(leftWall);

            Face rightWall = new Face(Color4.LightSalmon);
            rightWall.addVertex(new float[3] { 0.2f, 0.0f, 0.3f });
            rightWall.addVertex(new float[3] { 0.2f, 0.2f, 0.3f });
            rightWall.addVertex(new float[3] { 0.2f, 0.2f, -0.3f });
            rightWall.addVertex(new float[3] { 0.2f, 0.0f, -0.3f });
            faces.Add(rightWall);

            Face frontWall = new Face(Color4.Blue);
            frontWall.addVertex(new float[3] { 0.2f, 0.0f, 0.3f });
            frontWall.addVertex(new float[3] { -0.2f, 0.0f, 0.3f });
            frontWall.addVertex(new float[3] { -0.2f, 0.2f, 0.3f });
            frontWall.addVertex(new float[3] { 0.2f, 0.2f, 0.3f });
            faces.Add(frontWall);

            Face backWall = new Face(Color4.LightGray);
            backWall.addVertex(new float[3] { 0.2f, 0.0f, -0.3f });
            backWall.addVertex(new float[3] { -0.2f, 0.0f, -0.3f });
            backWall.addVertex(new float[3] { -0.2f, 0.2f, -0.3f });
            backWall.addVertex(new float[3] { 0.2f, 0.2f, -0.3f });
            faces.Add(backWall);

            Face frontAtticWall = new Face(Color4.DarkBlue);
            frontAtticWall.addVertex(new float[3] { 0.2f, 0.2f, 0.3f });
            frontAtticWall.addVertex(new float[3] { -0.2f, 0.2f, 0.3f });
            frontAtticWall.addVertex(new float[3] { 0.0f, 0.35f, 0.3f });
            faces.Add(frontAtticWall);

            Face backAtticWall = new Face(Color4.DarkGray);
            backAtticWall.addVertex(new float[3] { 0.2f, 0.2f, -0.3f });
            backAtticWall.addVertex(new float[3] { -0.2f, 0.2f, -0.3f });
            backAtticWall.addVertex(new float[3] { 0.0f, 0.35f, -0.3f });
            faces.Add(backAtticWall);

            Face leftRoof = new Face(Color4.Orange);
            leftRoof.addVertex(new float[3] { -0.2f, 0.2f, 0.3f });
            leftRoof.addVertex(new float[3] { -0.2f, 0.2f, -0.3f });
            leftRoof.addVertex(new float[3] { 0.0f, 0.35f, -0.3f });
            leftRoof.addVertex(new float[3] { 0.0f, 0.35f, 0.3f });
            faces.Add(leftRoof);

            Face rightRoof = new Face(Color4.Orange);
            leftRoof.addVertex(new float[3] { 0.2f, 0.2f, 0.3f });
            leftRoof.addVertex(new float[3] { 0.2f, 0.2f, -0.3f });
            leftRoof.addVertex(new float[3] { 0.0f, 0.35f, -0.3f });
            leftRoof.addVertex(new float[3] { 0.0f, 0.35f, 0.3f });
            faces.Add(leftRoof);

            Face door = new Face(Color4.Brown);
            door.addVertex(new float[3] { 0.05f, 0.0f, 0.3f });
            door.addVertex(new float[3] { -0.05f, 0.0f, 0.3f });
            door.addVertex(new float[3] { -0.05f, 0.1f, 0.3f });
            door.addVertex(new float[3] { 0.05f, 0.1f, 0.3f });
            faces.Add(door);

            return faces;
        }
    }
}
