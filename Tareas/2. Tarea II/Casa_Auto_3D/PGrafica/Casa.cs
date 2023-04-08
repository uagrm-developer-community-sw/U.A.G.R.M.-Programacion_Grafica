using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
namespace PGrafica
{
    class Casa
    {
        public float x;
        public float y;
        public float z;
        public float altura;
        public float profundidad;
        public float anchura;
        public Casa(float x, float y, float z, float anchura, float altura, float profundidad) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.anchura = anchura;
            this.altura = altura;
            this.profundidad = profundidad;
        }
        

        public  void Dibujar() {
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

            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);
        }

        private void Ptrasera()
        {
            float[] _vertices = {
                x+(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 0.5f, 0.0f,
                x+(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 0.5f, 0.0f,
                x-(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 0.5f, 0.0f,
                x+(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 0.5f, 0.0f,
                x-(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 0.5f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 0.5f, 0.0f,
            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

        }

        private void Pderecha()
        {
            float[] _vertices = {
                x+(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y-((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

        }

        private void Pizquierda()
        {
            float[] _vertices = {
                x-(anchura/2), y-((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y-((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,

            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);
        }

        private void Parriba()
        {
            float[] _vertices = {
                x+(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,

            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);
        }
        private void Pabajo()
        {
            float[] _vertices = {
                x-(anchura/2), y-((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y-((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y-((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x+(anchura/2), y-((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

        }

        private void PTfrontal(){
            float[] _vertices = {
                x+(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
                x, y+((0.35f*altura)+((0.65f*altura)/2)), z-(profundidad/2), 1.0f, 1.0f, 0.0f,
            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
        }
        private void PTtrasera()
        {
            float[] _vertices = {
                x+(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
                x, y+((0.35f*altura)+((0.65f*altura)/2)), z+(profundidad/2), 1.0f, 1.0f, 0.0f,
            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
        }

        private void Tderecho()
        {
            float[] _vertices = {
                x+(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 0.1f, 0.0f, 0.0f,
                x+(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
                x, y+((0.35f*altura)+((0.65f*altura)/2)), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
                x, y+((0.35f*altura)+((0.65f*altura)/2)), z+(profundidad/2),0.1f, 0.0f, 0.0f,
                x+(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 0.1f, 0.0f, 0.0f,
                x, y+((0.35f*altura)+((0.65f*altura)/2)), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

        }

        private void Tizquierdo()
        {
            float[] _vertices = {
                x-(anchura/2), y+((0.65f*altura)/2), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 0.1f, 0.0f, 0.0f,
                x, y+((0.35f*altura)+((0.65f*altura)/2)), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
                x, y+((0.35f*altura)+((0.65f*altura)/2)), z+(profundidad/2), 0.1f, 0.0f, 0.0f,
                x-(anchura/2), y+((0.65f*altura)/2), z+(profundidad/2), 0.1f, 0.0f, 0.0f,
                x, y+((0.35f*altura)+((0.65f*altura)/2)), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);
             
        }

        private void Puerta()
        {
            float[] _vertices = {
                x+((anchura/2)*0.2f), y-((0.65f*altura)/2), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
                x+((anchura/2)*0.2f), y-(((0.65f*altura)/2)*0.3f), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
                x-((anchura/2)*0.2f), y-((0.65f*altura)/2), z-(profundidad/2), 0.1f, 0.0f, 0.0f,

                x-((anchura/2)*0.2f), y-(((0.65f*altura)/2)*0.3f), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
                x-((anchura/2)*0.2f), y-((0.65f*altura)/2), z-(profundidad/2), 0.1f, 0.0f, 0.0f,
                x+((anchura/2)*0.2f), y-(((0.65f*altura)/2)*0.3f), z-(profundidad/2), 0.1f, 0.0f, 0.0f,

            };
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);
        }
    }
}
