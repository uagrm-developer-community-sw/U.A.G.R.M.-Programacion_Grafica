using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    public class Face : IDrawable
    {
        public Color4 color { get; set; }
        public List<Vertex> vertices { get; set; }
        //List<Vector3> normals;    //Para las texturas

        private Matrix4 transformations;
        private Matrix4 iTransformations;

        public Face()
        {
            vertices = new List<Vertex>();
            color = Color4.Gray;
            transformations = Matrix4.Identity;
            iTransformations = Matrix4.Identity;
        }

        public Face(Color4 color)
        {
            vertices = new List<Vertex>();
            this.color = color;
            transformations = Matrix4.Identity;
            iTransformations = Matrix4.Identity;
        }

        public void AddVertex(float x, float y, float z)
        {
            vertices.Add(new Vertex(x, y, z));
        }

        public void Translate(float x, float y, float z)
        {
            transformations = Matrix4.Mult(transformations, Matrix4.CreateTranslation(x, y, z));
        }

        public void Scale(float n)
        {
            iTransformations = Matrix4.Mult(iTransformations, Matrix4.CreateScale(n));
        }

        public void ScaleWithStage(Vertex origin, float n)
        {
            transformations = Matrix4.Mult(transformations, Matrix4.CreateTranslation(origin.x, origin.y, origin.z));
            transformations = Matrix4.Mult(transformations, Matrix4.CreateScale(n));
            transformations = Matrix4.Mult(transformations, Matrix4.CreateTranslation(-origin.x, -origin.y, -origin.z));
        }

        public void Rotate(string axis, float grades)
        {
            float radians = MathHelper.DegreesToRadians(grades);
            if (axis == "x")
                iTransformations = Matrix4.Mult(iTransformations, Matrix4.CreateRotationX(radians));
            else if (axis == "y")
                iTransformations = Matrix4.Mult(iTransformations, Matrix4.CreateRotationY(radians));
            else if (axis == "z")
                iTransformations = Matrix4.Mult(iTransformations, Matrix4.CreateRotationZ(radians));
        }

        public void RotateWithStage(Vertex origin, string axis, float grades)
        {
            float radians = MathHelper.DegreesToRadians(grades);

            transformations = Matrix4.Mult(transformations, Matrix4.CreateTranslation(origin.x, origin.y, origin.z));

            if (axis == "x")
                transformations = Matrix4.Mult(transformations, Matrix4.CreateRotationX(radians));
            else if (axis == "y")
                transformations = Matrix4.Mult(transformations, Matrix4.CreateRotationY(radians));
            else if (axis == "z")
                transformations = Matrix4.Mult(transformations, Matrix4.CreateRotationZ(radians));

            transformations = Matrix4.Mult(transformations, Matrix4.CreateTranslation(-origin.x, -origin.y, -origin.z));
        }

        public void Draw()
        {
            GL.Color4(Color4.Black);
            GL.Begin(BeginMode.LineLoop);
            foreach (Vertex v in vertices)
            {
                Vector4 iModified = Vector4.Transform(new Vector4(v.x, v.y, v.z, 1), iTransformations);
                Vector4 modified = Vector4.Transform(iModified, transformations);
                GL.Vertex4(modified);
            }
            GL.End();

            GL.Color4(color);
            GL.Begin(BeginMode.Polygon);
            foreach (Vertex v in vertices)
            {
                Vector4 iModified = Vector4.Transform(new Vector4(v.x, v.y, v.z, 1), iTransformations);
                Vector4 modified = Vector4.Transform(iModified, transformations);
                GL.Vertex4(modified);
            }
            GL.End();

            iTransformations = Matrix4.Identity;
            transformations = Matrix4.Identity;
        }

    }
}
