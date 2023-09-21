using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Object3D
    {
        private List<Face> faces;
        private float[] centroid;

        public Object3D(float[] centroid)
        {
            this.centroid = centroid;
            faces = new List<Face>();
        }

        public Object3D(float[] centroid, List<Face> faces)
        {
            this.centroid = centroid;
            this.faces = faces;
        }

        public void draw()
        {
            foreach (Face face in faces)
            {
                face.draw(centroid);
            }
        }

        public void addFace(Face face)
        {
            faces.Add(face);
        }

        public void removeFace(Face face)
        {
            faces.Remove(face);
        }
    }
}
