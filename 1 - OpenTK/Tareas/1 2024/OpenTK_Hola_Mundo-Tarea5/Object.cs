using OpenTK;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Object : IDrawable
    {
        public Vertex center { get; set; }
        public List<Face> faces { get; set; }

        public Object() 
        {
            center = new Vertex(0, 0, 0);
        }

        public Object(float x, float y, float z)
        {
            center = new Vertex(x, y, z);
            faces = new List<Face>();
        }

        public void Translate(float x, float y, float z)
        {
            foreach (Face face in faces)
            {
                face.Translate(x, y, z);
            }
        }

        public void Scale(float n)
        {
            foreach (Face face in faces)
            {
                face.Scale(n);
            }
        }

        public void ScaleWithStage(Vertex origin, float n)
        {
            Vertex v = new Vertex(origin.x + center.x, origin.y + center.y, origin.z + center.z);
            foreach (Face face in faces)
            {
                face.ScaleWithStage(v, n);
            }
        }

        public void Rotate(string axis, float grades)
        {
            foreach (Face f in faces)
            {
                f.Rotate(axis, grades);
            }
        }

        public void RotateWithStage(Vertex origin, string axis, float grades)
        {
            Vertex v = new Vertex(origin.x + center.x, origin.y + center.y, origin.z + center.z);
            foreach (Face f in faces)
            {
                f.RotateWithStage(v, axis, grades);
            }
        }

        public void Draw()
        {
            //Axises.Draw(center, 10);
            foreach (Face f in faces)
            {
                f.Translate(center.x, center.y, center.z);
                f.Draw();
                //f.Draw(new Vertex(origin.x + center.x, origin.y + center.y, origin.z + center.z));
            }
        }
    }
}
