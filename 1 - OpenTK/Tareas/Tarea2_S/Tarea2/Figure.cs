using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Tarea2
{
    class Figure
    {
        public void dibujarT()
        {
            //--------------------------------
            // PARTE SUPERIOR T
            //parteSperiorFrente();
            //parteSperiorLadoIzquierdo();
            //parteSperiorLadoDerecho();
            //parteSperiorAtras();
            parteSperior();
            parteInferior();

            //--------------------------------
            // PARTE CUERPO T
            cuerpoT();
        }

        //------------------------------------------------------
        // METODO QUE SE LLAMA AL DIBUJAR EL PROGRAMA (PARTE SUPERIOR T)
        
        private void parteSperiorFrente()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo

            // Frente
            GL.Vertex3(-0.5f, 0.5f, 0.0f); // Esquina superior izquierda
            GL.Vertex3(0.5f, 0.5f, 0.0f);  // Esquina superior derecha
            GL.Vertex3(0.5f, 0.3f, 0.0f);  // Esquina inferior derecha
            GL.Vertex3(-0.5f, 0.3f, 0.0f); // Esquina inferior izquierda
        }

        private void parteSperiorAtras()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde

            // Atrás
            GL.Vertex3(-0.5f, 0.5f, -0.1f); // Esquina superior izquierda
            GL.Vertex3(0.5f, 0.5f, -0.1f);  // Esquina superior derecha
            GL.Vertex3(0.5f, 0.3f, -0.1f);  // Esquina inferior derecha
            GL.Vertex3(-0.5f, 0.3f, -0.1f); // Esquina inferior izquierda
        }

        private void parteSperiorLadoIzquierdo()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde

            // Lado izquierdo
            GL.Vertex3(-0.5f, 0.5f, 0.0f); // Frente superior
            GL.Vertex3(-0.5f, 0.5f, -0.1f); // Atrás superior
            GL.Vertex3(-0.5f, 0.3f, -0.1f); // Atrás inferior
            GL.Vertex3(-0.5f, 0.3f, 0.0f); // Frente inferior
        }

        private void parteSperiorLadoDerecho()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde

            // Lado derecho
            GL.Vertex3(0.5f, 0.5f, 0.0f); // Frente superior
            GL.Vertex3(0.5f, 0.5f, -0.1f); // Atrás superior
            GL.Vertex3(0.5f, 0.3f, -0.1f); // Atrás inferior
            GL.Vertex3(0.5f, 0.3f, 0.0f); // Frente inferior
        }

        private void parteSperior()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo

            // Superior
            GL.Vertex3(-0.5f, 0.5f, 0.0f); // Frente izquierdo
            GL.Vertex3(0.5f, 0.5f, 0.0f);  // Frente derecho
            GL.Vertex3(0.5f, 0.5f, -0.1f); // Atrás derecho
            GL.Vertex3(-0.5f, 0.5f, -0.1f); // Atrás izquierdo
        }

        private void parteInferior()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo

            // Inferior
            GL.Vertex3(-0.5f, 0.3f, 0.0f); // Frente izquierdo
            GL.Vertex3(0.5f, 0.3f, 0.0f);  // Frente derecho
            GL.Vertex3(0.5f, 0.3f, -0.1f); // Atrás derecho
            GL.Vertex3(-0.5f, 0.3f, -0.1f); // Atrás izquierdo
        }

        //------------------------------------------------------
        // METODO QUE SE LLAMA AL DIBUJAR EL PROGRAMA (PARTE CUERPO T)
        private void cuerpoT()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 0.0f, 1.0f); // Color azul

            // Frente
            GL.Vertex3(-0.1f, 0.3f, 0.0f); // Esquina superior izquierda
            GL.Vertex3(0.1f, 0.3f, 0.0f);  // Esquina superior derecha
            GL.Vertex3(0.1f, -0.5f, 0.0f); // Esquina inferior derecha
            GL.Vertex3(-0.1f, -0.5f, 0.0f); // Esquina inferior izquierda

            // Atrás
            GL.Vertex3(-0.1f, 0.3f, -0.1f); // Esquina superior izquierda
            GL.Vertex3(0.1f, 0.3f, -0.1f);  // Esquina superior derecha
            GL.Vertex3(0.1f, -0.5f, -0.1f); // Esquina inferior derecha
            GL.Vertex3(-0.1f, -0.5f, -0.1f); // Esquina inferior izquierda

            // Lado izquierdo
            GL.Vertex3(-0.1f, 0.3f, 0.0f); // Frente superior
            GL.Vertex3(-0.1f, 0.3f, -0.1f); // Atrás superior
            GL.Vertex3(-0.1f, -0.5f, -0.1f); // Atrás inferior
            GL.Vertex3(-0.1f, -0.5f, 0.0f); // Frente inferior

            // Lado derecho
            GL.Vertex3(0.1f, 0.3f, 0.0f); // Frente superior
            GL.Vertex3(0.1f, 0.3f, -0.1f); // Atrás superior
            GL.Vertex3(0.1f, -0.5f, -0.1f); // Atrás inferior
            GL.Vertex3(0.1f, -0.5f, 0.0f); // Frente inferior

            GL.End();
        }
    }
}