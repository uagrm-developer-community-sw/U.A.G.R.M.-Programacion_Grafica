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
            // PARTE CUERPO T
            cuerpoTAtras();
            cuerpoTLadoIzquierda();
            cuerpoTLadoDerecho();
            cuerpoSuperio();
            cuerpoInferior();
            cuerpoTFrente();

            //--------------------------------
            // PARTE SUPERIOR T
            parteInferior();
            parteLadoDerecho();
            parteLadoIzquierdo();
            parteSperiorAtras();
            parteSperiorFrente();
            parteSperior();

        }

        //------------------------------------------------------
        // METODO QUE SE LLAMA AL DIBUJAR EL PROGRAMA (PARTE SUPERIOR T)

        private void parteSperiorFrente()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0f, 1.0f, 0.0f); // Color amarillo

            // Frente (reducido en tamaño de derecha e izquierda)
            GL.Vertex3(-0.4f, 0.45f, 0.1f); // Esquina superior izquierda
            GL.Vertex3(0.4f, 0.45f, 0.1f);  // Esquina superior derecha
            GL.Vertex3(0.4f, 0.25f, 0.1f);  // Esquina inferior derecha
            GL.Vertex3(-0.4f, 0.25f, 0.1f); // Esquina inferior izquierda
            GL.End();
        }

        private void parteSperiorAtras()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde

            // Atrás (reducido en tamaño de derecha e izquierda y movido hacia la derecha)
            GL.Vertex3(-0.3f, 0.55f, -0.1f); // Esquina superior izquierda
            GL.Vertex3(0.5f, 0.55f, -0.1f);  // Esquina superior derecha
            GL.Vertex3(0.5f, 0.35f, -0.1f);  // Esquina inferior derecha
            GL.Vertex3(-0.3f, 0.35f, -0.1f); // Esquina inferior izquierda
            GL.End();
        }

        private void parteLadoIzquierdo()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde

            // Lado izquierdo (ajustado para acoplarse a parteSperiorFrente y parteSperiorAtras)
            GL.Vertex3(-0.4f, 0.45f, 0.1f); // Frente superior
            GL.Vertex3(-0.3f, 0.55f, -0.1f); // Atrás superior
            GL.Vertex3(-0.3f, 0.35f, -0.1f); // Atrás inferior
            GL.Vertex3(-0.4f, 0.25f, 0.1f); // Frente inferior
            GL.End();
        }

        private void parteLadoDerecho()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde

            // Lado derecho (ajustado para acoplarse a parteSperiorFrente y parteSperiorAtras)
            GL.Vertex3(0.4f, 0.45f, 0.1f); // Frente superior
            GL.Vertex3(0.5f, 0.55f, -0.1f); // Atrás superior
            GL.Vertex3(0.5f, 0.35f, -0.1f); // Atrás inferior
            GL.Vertex3(0.4f, 0.25f, 0.1f); // Frente inferior
            GL.End();
        }

        private void parteSperior()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo

            // Superior
            GL.Vertex3(-0.4f, 0.45f, 0.1f); // Frente izquierdo
            GL.Vertex3(0.4f, 0.45f, 0.1f);  // Frente derecho
            GL.Vertex3(0.5f, 0.55f, -0.1f); // Atrás derecho
            GL.Vertex3(-0.3f, 0.55f, -0.1f); // Atrás izquierdo
            GL.End();
        }

        private void parteInferior()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo

            // Inferior
            GL.Vertex3(-0.4f, 0.25f, 0.1f); // Frente izquierdo
            GL.Vertex3(0.4f, 0.25f, 0.1f);  // Frente derecho
            GL.Vertex3(0.5f, 0.35f, -0.1f); // Atrás derecho
            GL.Vertex3(-0.3f, 0.35f, -0.1f); // Atrás izquierdo
            GL.End();
        }



        //------------------------------------------------------
        // METODO QUE SE LLAMA AL DIBUJAR EL PROGRAMA (PARTE CUERPO T)

        private void cuerpoTFrente()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo

            // Frente
            GL.Vertex3(-0.1f, 0.3f, 0.0f); // Esquina superior izquierda
            GL.Vertex3(0.1f, 0.3f, 0.0f);  // Esquina superior derecha
            GL.Vertex3(0.1f, -0.5f, 0.0f); // Esquina inferior derecha
            GL.Vertex3(-0.1f, -0.5f, 0.0f); // Esquina inferior izquierda

            GL.End();
        }

        private void cuerpoTAtras() {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 0.0f, 1.0f); // Color azul

            // Atrás (más a la derecha y arriba)
            GL.Vertex3(-0.1f, 0.4f, -0.2f); // Esquina superior izquierda
            GL.Vertex3(0.2f, 0.4f, -0.2f);  // Esquina superior derecha
            GL.Vertex3(0.2f, -0.4f, -0.2f); // Esquina inferior derecha
            GL.Vertex3(-0.1f, -0.4f, -0.2f); // Esquina inferior izquierda

            GL.End();
        }

        private void cuerpoTLadoIzquierda()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 0.0f, 1.0f); // Color azul

            // Lado izquierdo
            GL.Vertex3(-0.1f, 0.3f, 0.0f); // Frente superior
            GL.Vertex3(-0.1f, 0.4f, -0.2f); // Atrás superior
            GL.Vertex3(-0.1f, -0.4f, -0.2f); // Atrás inferior
            GL.Vertex3(-0.1f, -0.5f, 0.0f); // Frente inferior

            GL.End();

        }

        private void cuerpoTLadoDerecho()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 0.0f, 1.0f); // Color azul

            // Lado derecho
            GL.Vertex3(0.1f, 0.3f, 0.0f); // Frente superior
            GL.Vertex3(0.2f, 0.4f, -0.2f); // Atrás superior
            GL.Vertex3(0.2f, -0.4f, -0.2f); // Atrás inferior
            GL.Vertex3(0.1f, -0.5f, 0.0f); // Frente inferior

            GL.End();

        }

        private void cuerpoSuperio()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 0.0f, 1.0f); // Color azul

            // Parte superior
            GL.Vertex3(-0.1f, 0.3f, 0.0f); // Frente izquierdo
            GL.Vertex3(0.1f, 0.3f, 0.0f);  // Frente derecho
            GL.Vertex3(0.2f, 0.4f, -0.2f); // Atrás derecho
            GL.Vertex3(-0.1f, 0.4f, -0.2f); // Atrás izquierdo

            GL.End();
        }

        private void cuerpoInferior()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 0.0f, 1.0f); // Color azul

            // Parte inferior
            GL.Vertex3(-0.1f, -0.5f, 0.0f); // Frente izquierdo
            GL.Vertex3(0.1f, -0.5f, 0.0f);  // Frente derecho
            GL.Vertex3(0.2f, -0.4f, -0.2f); // Atrás derecho
            GL.Vertex3(-0.1f, -0.4f, -0.2f); // Atrás izquierdo

            GL.End();

        }
    }
}