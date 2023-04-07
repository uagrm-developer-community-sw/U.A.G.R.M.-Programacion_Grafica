using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace Casa_Auto_3D
{
    internal class Casa_auto_3D
    {
        public float x;
        public float y;
        public float z;
        public float altura;
        public float profundidad;
        public float anchura;
        public Casa_auto_3D(float x, float y, float z, float anchura, float altura, float profundidad) 
        { 
            this.x = x; 
            this.y = y; 
            this.z = z;
            this.anchura = anchura;
            this.altura = altura;
            this.profundidad = profundidad;
        }

        public void Dibujar()
        {
            DibujarPared();
            DibujarTecho();
        }

        private void DibujarTecho()
        {
            PTfrontal();
            PTtrasera();
            Tderecho();
            Tizquierdo();
        }

        private void DibujarPared()
        {
            Pderecha();
            Pizquierda();
            Pabajo();
            Parriba();
            Pfrontal();
            Ptrasera();
            Puerta();
        }

        private void Pfrontal()
        {
            float[] _vertices = {
                x-(anchura/2), y - ((0.65f*altura)/2), z-(profundidad/2), 1.0f, 0.5f, 0.0f,
                x-(anchura/2), y + ((0.65f*altura)/2), z-(profundidad/2), 1.0f, 0.5f, 0.0f,
                x+(anchura/2), y - ((0.65f*altura)/2), z-(profundidad/2), 1.0f, 0.5f, 0.0f,
                x-(anchura/2), y + ((0.65f*altura)/2), z-(profundidad/2), 1.0f, 0.5f, 0.0f,
                x+(anchura/2), y - ((0.65f*altura)/2), z-(profundidad/2), 1.0f, 0.5f, 0.0f,
                x+(anchura/2), y + ((0.65f*altura)/2), z-(profundidad/2), 1.0f, 0.5f, 0.0f,
            };

        }         
    }
}
