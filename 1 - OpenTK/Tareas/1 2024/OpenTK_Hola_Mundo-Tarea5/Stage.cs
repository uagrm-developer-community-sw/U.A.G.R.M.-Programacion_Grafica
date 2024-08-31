using OpenTK;
using System;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Stage : IDrawable
    {
        public Vertex center { get; set; }
        public Dictionary<string, Object> objects { get; set; }

        public Stage() 
        {
            center = new Vertex(0, 0, 0);
        }

        public Stage(float x, float y, float z)
        {
            center = new Vertex(x, y, z);
            objects = new Dictionary<string, Object>();
        }

        public void Translate(float x, float y, float z)
        {
            foreach (Object obj in objects.Values)
            {
                obj.Translate(x, y, z);
            }
        }

        public void Scale(float n)
        {
            foreach (Object obj in objects.Values)
            {
                obj.ScaleWithStage(center, n);
            }
        }

        public void Rotate(string axis, float grades)
        {
            foreach (Object obj in objects.Values)
            {
                obj.RotateWithStage(center, axis, grades);
            }
        }

        public void Draw()
        {
            //Axises.Draw(center, 30);
            //Si dibujo aqui el piso la parte de los objetos que esten debajo del piso no se veran
            foreach (Object obj in objects.Values)
            {
                obj.Translate(center.x, center.y, center.z);
                obj.Draw();
            }
            //Axises.DrawFloor(center, 60);
        }
    }
}
