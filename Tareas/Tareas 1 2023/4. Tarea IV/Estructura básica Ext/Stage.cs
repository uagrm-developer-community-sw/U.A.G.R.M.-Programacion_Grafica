using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Stage
    {
        private List<Object3D> objects;
        public Stage()
        {
            objects = new List<Object3D>();
        }

        public void draw()
        {
            foreach (Object3D obj in objects)
            {
                obj.draw();
            }
        }

        public void addObject(Object3D object3D)
        {
            objects.Add(object3D);
        }

        public void removeObject(Object3D object3D)
        {
            objects.Remove(object3D);
        }
    }
}
