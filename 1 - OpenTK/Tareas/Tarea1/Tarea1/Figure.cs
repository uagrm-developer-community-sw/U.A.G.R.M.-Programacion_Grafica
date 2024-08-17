using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1
{
    class Figure
    {
        // Dibuja un televisor en la posición actual
        public void dibujarletraT()
        {
            parteSuperiorAtrasT();
            izquierdoLetraT();
            tapaSuperiorLetraT();
            tapaInferiorLetraT();
            derechioLetraT();
            parteSuperiorLetraT();
        }
        
        public void dibujarTv()
        {
            izquierdoTv();
            tapaSuperiorTv();
            tapaInferiorTv();
            derechoTv();
        }
        //-------------------------------------------------------------------------------------
        // Parte delantera de la letra T {#d0f,13}
        private void parteSuperiorLetraT()
        {
            GL.Begin(PrimitiveType.Quads); // Inicia el dibujo de un cuadrilátero

            GL.Color3(1.0f, 0.5f, 0.0f); // Establece el color naranja chillón

            // Define los vértices para la parte superior de la T
            GL.Vertex3(-0.7f, 0.3f, 0.5f); // Esquina inferior izquierda
            GL.Vertex3(0.7f, 0.3f, 0.5f);  // Esquina inferior derecha
            GL.Vertex3(0.7f, 0.5f, 0.5f);  // Esquina superior derecha
            GL.Vertex3(-0.7f, 0.5f, 0.5f); // Esquina superior izquierda

            GL.End(); // Finaliza el dibujo
        }
        //-------------------------------------------------------------------------------------
        // Parte trasera de la letra T {#d0f,13} 
        private void parteSuperiorAtrasT()
        {
            GL.Begin(PrimitiveType.Quads); // Inicia el dibujo de un cuadrilátero

            GL.Color3(0.1f, 0.1f, 0.1f); // Establece el color gris oscuro

            // Define los vértices para la parte superior trasera de la T con un desplazamiento
            GL.Vertex3(-0.7f + 0.1f, 0.3f + 0.05f, -0.5f); // Esquina inferior izquierda
            GL.Vertex3(0.7f + 0.1f, 0.3f + 0.05f, -0.5f);  // Esquina inferior derecha
            GL.Vertex3(0.7f + 0.1f, 0.5f + 0.05f, -0.5f);  // Esquina superior derecha
            GL.Vertex3(-0.7f + 0.1f, 0.5f + 0.05f, -0.5f); // Esquina superior izquierda

            GL.End(); // Finaliza el dibujo
        }
        //-------------------------------------------------------------------------------------
        // Parte derecha de la letra T {#eac,13}
        private void derechoTv()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 1.0f, 0.0f); // Color verde chillón

            GL.Vertex3(0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior trasera
            GL.Vertex3(0.5f, -0.4f, 0.5f); // Esquina inferior delantera
            GL.Vertex3(0.5f, 0.4f, 0.5f); // Esquina superior delantera 2
            GL.Vertex3(0.5f + 0.1f, 0.4f + 0.05f, -0.5f); // Esquina superior trasera 1

            GL.End();
        }
        //-------------------------------------------------------------------------------------
        // Parte izquierdo de la letra T {#eac,13}
        private void izquierdoTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(1.0f, 1.0f, 0.0f); // Color amarillo chillón

            GL.Vertex3(-0.5f, -0.4f, 0.5f); // Esquina inferior delantera
            GL.Vertex3(-0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior trasera
            GL.Vertex3(-0.5f + 0.1f, 0.4f + 0.05f, -0.5f);  // Esquina superior trasera
            GL.Vertex3(-0.5f, 0.4f, 0.5f);  // Esquina superior delantera

            GL.End();
        }
        //-------------------------------------------------------------------------------------

        // Parte superior de la letra T {#ef0,13}
        private void tapaSuperiorTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(1.0f, 0.0f, 1.0f); // Color naranja chillón

            GL.Vertex3(-0.5f, 0.4f, 0.5f);  // Esquina superior izquierda delantera
            GL.Vertex3(0.5f, 0.4f, 0.5f);   // Esquina superior derecha delantera
            GL.Vertex3(0.5f + 0.1f, 0.4f + 0.05f, -0.5f); // Esquina superior derecha trasera
            GL.Vertex3(-0.5f + 0.1f, 0.4f + 0.05f, -0.5f);  // Esquina superior izquierda trasera

            GL.End();
        }
        //-------------------------------------------------------------------------------------
        // Parte inferior de la latra T {#ef0,13}
        private void tapaInferiorTv()
        {
            GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

            GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo chillón

            GL.Vertex3(-0.5f, -0.4f, 0.5f); // Esquina inferior izquierda delantera
            GL.Vertex3(0.5f, -0.4f, 0.5f); // Esquina inferior derecha delantera
            GL.Vertex3(0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior derecha trasera
            GL.Vertex3(-0.5f + 0.1f, -0.4f + 0.05f, -0.5f); // Esquina inferior izquierda trasera

            GL.End();
        }
        //-------------------------------------------------------------------------------------
    }
}
