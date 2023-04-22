using OpenTK.Graphics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Car
    {
        public static List<Face> GetFaces()
        {
            List<Face> faces = new List<Face>();

            Face front = new Face(Color4.Magenta);
            front.addVertex(new float[3] { 0.1f, 0.05f, 0.2f });
            front.addVertex(new float[3] { -0.1f, 0.05f, 0.2f });
            front.addVertex(new float[3] { -0.1f, 0.1f, 0.2f });
            front.addVertex(new float[3] { 0.1f, 0.1f, 0.2f });
            faces.Add(front);

            Face hood = new Face(Color4.Red);
            hood.addVertex(new float[3] { 0.1f, 0.1f, 0.2f});
            hood.addVertex(new float[3] { -0.1f, 0.1f, 0.2f });
            hood.addVertex(new float[3] { -0.1f, 0.15f, 0.0f });
            hood.addVertex(new float[3] { 0.1f, 0.15f, 0.0f });
            faces.Add(hood);

            Face windshield = new Face(Color4.LightGray);
            windshield.addVertex(new float[3] { 0.1f, 0.15f, 0.0f });
            windshield.addVertex(new float[3] { -0.1f, 0.15f, 0.0f });
            windshield.addVertex(new float[3] { -0.1f, 0.2f, -0.02f });
            windshield.addVertex(new float[3] { 0.1f, 0.2f, -0.02f });
            faces.Add(windshield);

            Face roof = new Face(Color4.Red);
            roof.addVertex(new float[3] { 0.1f, 0.2f, -0.02f });
            roof.addVertex(new float[3] { -0.1f, 0.2f, -0.02f });
            roof.addVertex(new float[3] { -0.1f, 0.2f, -0.3f });
            roof.addVertex(new float[3] { 0.1f, 0.2f, -0.3f });
            faces.Add(roof);

            Face back = new Face(Color4.Red);
            back.addVertex(new float[3] { 0.1f, 0.05f, -0.3f });
            back.addVertex(new float[3] { -0.1f, 0.05f, -0.3f });
            back.addVertex(new float[3] { -0.1f, 0.2f, -0.3f });
            back.addVertex(new float[3] { 0.1f, 0.2f, -0.3f });
            faces.Add(back);

            Face left = new Face(Color4.Red);
            left.addVertex(new float[3] { -0.1f, 0.05f, 0.2f });
            left.addVertex(new float[3] { -0.1f, 0.1f, 0.2f });
            left.addVertex(new float[3] { -0.1f, 0.15f, 0.0f });
            left.addVertex(new float[3] { -0.1f, 0.2f, -0.02f });
            left.addVertex(new float[3] { -0.1f, 0.2f, -0.3f });
            left.addVertex(new float[3] { -0.1f, 0.05f, -0.3f });
            faces.Add(left);

            Face right = new Face(Color4.Red); 
            right.addVertex(new float[3] { 0.1f, 0.05f, 0.2f });
            right.addVertex(new float[3] { 0.1f, 0.1f, 0.2f });
            right.addVertex(new float[3] { 0.1f, 0.15f, 0.0f });
            right.addVertex(new float[3] { 0.1f, 0.2f, -0.02f });
            right.addVertex(new float[3] { 0.1f, 0.2f, -0.3f });
            right.addVertex(new float[3] { 0.1f, 0.05f, -0.3f });
            faces.Add(right);

            Face frontRightWheel = new Face(Color4.LightGray);
            frontRightWheel.addVertex(new float[3] { 0.1f, 0.07f, 0.1f});
            frontRightWheel.addVertex(new float[3] { 0.1f, 0.08f, 0.07f });
            frontRightWheel.addVertex(new float[3] { 0.1f, 0.07f, 0.04f });
            frontRightWheel.addVertex(new float[3] { 0.1f, 0.02f, 0.04f });
            frontRightWheel.addVertex(new float[3] { 0.1f, 0.01f, 0.07f });
            frontRightWheel.addVertex(new float[3] { 0.1f, 0.02f, 0.1f });
            faces.Add(frontRightWheel);

            Face frontLeftWheel = new Face(Color4.LightGray);
            frontLeftWheel.addVertex(new float[3] { -0.1f, 0.07f, 0.1f });
            frontLeftWheel.addVertex(new float[3] { -0.1f, 0.08f, 0.07f });
            frontLeftWheel.addVertex(new float[3] { -0.1f, 0.07f, 0.04f });
            frontLeftWheel.addVertex(new float[3] { -0.1f, 0.02f, 0.04f });
            frontLeftWheel.addVertex(new float[3] { -0.1f, 0.01f, 0.07f });
            frontLeftWheel.addVertex(new float[3] { -0.1f, 0.02f, 0.1f });
            faces.Add(frontLeftWheel);

            Face backRightWheel = new Face(Color4.LightGray);
            backRightWheel.addVertex(new float[3] { 0.1f, 0.07f, -0.14f });
            backRightWheel.addVertex(new float[3] { 0.1f, 0.08f, -0.17f });
            backRightWheel.addVertex(new float[3] { 0.1f, 0.07f, -0.2f });
            backRightWheel.addVertex(new float[3] { 0.1f, 0.02f, -0.2f });
            backRightWheel.addVertex(new float[3] { 0.1f, 0.01f, -0.17f });
            backRightWheel.addVertex(new float[3] { 0.1f, 0.02f, -0.14f });
            faces.Add(backRightWheel);

            Face backLeftWheel = new Face(Color4.LightGray);
            backLeftWheel.addVertex(new float[3] { -0.1f, 0.07f, -0.14f });
            backLeftWheel.addVertex(new float[3] { -0.1f, 0.08f, -0.17f });
            backLeftWheel.addVertex(new float[3] { -0.1f, 0.07f, -0.2f });
            backLeftWheel.addVertex(new float[3] { -0.1f, 0.02f, -0.2f });
            backLeftWheel.addVertex(new float[3] { -0.1f, 0.01f, -0.17f });
            backLeftWheel.addVertex(new float[3] { -0.1f, 0.02f, -0.14f });
            faces.Add(backLeftWheel);

            return faces;
        }
    }
}
