using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor_OpenTK
{
    class Figure
    {
        public void dibujarTv()
        {
           
            marcoTv();
            pantallaTv();
            izquierdoTv();
            derechoTv();
            BaseTv();
            antenaIzquierda();
            antenaDerecha();
            baseInferiorTv();

        }

        // Parte delantera del televisor (marco)
        private void marcoTv()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.1f, 0.1f, 0.1f); // Color del marco (gris oscuro)
            GL.Vertex3(-0.6f, -0.4f, 0.5f); // Esquina inferior izquierda
            GL.Vertex3(0.6f, -0.4f, 0.5f);  // Esquina inferior derecha
            GL.Vertex3(0.6f, 0.4f, 0.5f);   // Esquina superior derecha
            GL.Vertex3(-0.6f, 0.4f, 0.5f);  // Esquina superior izquierda

            GL.End();
        }

        // Pantalla del televisor
        private void pantallaTv()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0f, 0.0f, 0.0f); // Color de la pantalla (negro)
            GL.Vertex3(-0.4f, -0.3f, 0.51f); // Esquina inferior izquierda
            GL.Vertex3(0.4f, -0.3f, 0.51f);  // Esquina inferior derecha
            GL.Vertex3(0.4f, 0.3f, 0.51f);   // Esquina superior derecha
            GL.Vertex3(-0.4f, 0.3f, 0.51f);  // Esquina superior izquierda

            GL.End();
        }

        // Lateral izquierdo del televisor
        private void izquierdoTv(){
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.1f, 0.1f, 0.1f); // Color del lateral (gris oscuro)
            GL.Vertex3(-0.6f, -0.4f, -0.5f); // Esquina inferior trasera
            GL.Vertex3(-0.6f, -0.4f, 0.5f); // Esquina inferior delantera
            GL.Vertex3(-0.6f, 0.4f, 0.5f); // Esquina superior delantera
            GL.Vertex3(-0.6f, 0.4f, -0.5f); // Esquina superior trasera

            GL.End();

        }

        // Lateral derecho del televisor
        private void derechoTv(){
            GL.Begin(PrimitiveType.Quads);

            GL.Vertex3(0.6f, -0.4f, -0.5f); // Esquina inferior trasera
            GL.Vertex3(0.6f, -0.4f, 0.5f); // Esquina inferior delantera
            GL.Vertex3(0.6f, 0.4f, 0.5f); // Esquina superior delantera
            GL.Vertex3(0.6f, 0.4f, -0.5f); // Esquina superior trasera

            GL.End();
        }

        // Base del televisor
        private void BaseTv()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.1f, 0.1f, 0.1f); // Color de la base (gris oscuro)
            GL.Vertex3(-0.6f, -0.4f, -0.5f); // Esquina inferior izquierda
            GL.Vertex3(0.6f, -0.4f, -0.5f);  // Esquina inferior derecha
            GL.Vertex3(0.6f, -0.5f, 0.5f);   // Esquina superior derecha
            GL.Vertex3(-0.6f, -0.5f, 0.5f);  // Esquina superior izquierda

            GL.End();
        }

        // Antena izquierda del televisor
        private void antenaIzquierda()
        {
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(0.0f, 0.0f, 0.0f); // Color de la antena (negro)
            GL.Vertex3(-0.4f, 0.4f, 0.5f); // Base de la antena
            GL.Vertex3(-0.4f, 0.6f, 0.5f); // Punta de la antena

            GL.End();
        }

        // Antena derecha del televisor
        private void antenaDerecha()
        {
            GL.Begin(PrimitiveType.Lines);

            GL.Color3(0.0f, 0.0f, 0.0f); // Color de la antena (negro)
            GL.Vertex3(0.4f, 0.4f, 0.5f); // Base de la antena
            GL.Vertex3(0.4f, 0.6f, 0.5f); // Punta de la antena

            GL.End();
        }

        // Base inferior del televisor
        private void baseInferiorTv()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.65f, 0.32f, 0.18f); // Color de la base (marrón)
            GL.Vertex3(-0.7f, -0.5f, -0.5f); // Esquina inferior izquierda
            GL.Vertex3(0.7f, -0.5f, -0.5f);  // Esquina inferior derecha
            GL.Vertex3(0.7f, -0.5f, 0.5f);   // Esquina superior derecha
            GL.Vertex3(-0.7f, -0.5f, 0.5f);  // Esquina superior izquierda

            GL.End();
        }
        
    }
}