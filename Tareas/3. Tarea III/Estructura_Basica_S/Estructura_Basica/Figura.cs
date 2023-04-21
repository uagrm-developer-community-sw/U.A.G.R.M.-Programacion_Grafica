using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Estructura_Basica
{
    internal class Figura
    {
        public Figura()
        {

        }

        public void dibujarMesa()
        {
            dibujarPataDelDer();
            dibujarPataDeIzq();
            dibujarPataTraDer();
            dibujarPataTraIzq();
            dibujarTablonDeMesa();
        }

        public void dibujarTablonDeMesa()
        {
            GL.Begin(BeginMode.Quads);      //Dibujamos la parte frontal con un cuadrado
            GL.Color3(0.0f, 1.0f, 0.0f);    //Color verde
            GL.Vertex3(-0.5f, 0.05f, 0.0f); //Vértice 0
            GL.Vertex3(-0.5f, 0.0f, 0.0f);  //Vértice 1
            GL.Vertex3(0.0f, 0.0f, 0.0f);   //Vértice 2
            GL.Vertex3(0.0f, 0.05f, 0.0f);  //Vértice 3
            GL.End();

            GL.Begin(BeginMode.Quads);      //Dibujamos la parte lateral derecha con un cuadrado
            GL.Color3(0.0f, 1.0f, 0.0f);    //Color verde
            GL.Vertex3(0.0f, 0.0f, 0.0f);   //Vértice 0
            GL.Vertex3(0.0f, 0.05f, 0.0f);  //Vértice 1
            GL.Vertex3(0.5f, 0.5f, -0.8f);  //Vértice 2
            GL.Vertex3(0.5f, 0.55f, -0.8f); //Vértice 3 
            GL.End();

            GL.Begin(BeginMode.Quads);      //Dibujamos la parte trasera con un cuadrado
            GL.Color3(0.0f, 1.0f, 0.0f);    //Color verde
            GL.Vertex3(0.0f, 0.5f, -0.8f);  //Vértice 0
            GL.Vertex3(0.0f, 0.55f, -0.8f); //Vértice 1 
            GL.Vertex3(0.5f, 0.55f, -0.8f);  //Vértice 2
            GL.Vertex3(0.5f, 0.5f, -0.8f);  //Vértice 3 
            GL.End();

            GL.Begin(BeginMode.Quads);      //Dibujamos la parte lateral izquierda con un cuadrado
            GL.Color3(0.0f, 1.0f, 0.0f);    //Color verde
            GL.Vertex3(-0.5f, 0.0f, 0.0f);  //Vértice 0
            GL.Vertex3(-0.5f, 0.05f, 0.0f); //Vértice 1
            GL.Vertex3(0.0f, 0.55f, -0.8f); //Vértice 2
            GL.Vertex3(0.0f, 0.5f, -0.8f);  //Vértice 3
            GL.End();

            GL.Begin(BeginMode.Quads);      //Dibujamos la parte superior con un cuadrado
            GL.Color3(1.0f, 0.5f, 0.5f);    //Color naranja
            GL.Vertex3(-0.5f, 0.05f, 0.0f); //Vértice 0
            GL.Vertex3(0.0f, 0.55f, -0.8f); //Vértice 1
            GL.Vertex3(0.5f, 0.55f, -0.8f); //Vértice 2
            GL.Vertex3(0.0f, 0.05f, 0.0f);  //Vértice 3
            GL.End();

            GL.Flush();

        }

        public void dibujarPataDelDer()
        {
            GL.Begin(BeginMode.Quads);       //Dibujamos la parte frontal con un cuadrado
            GL.Color3(1.0f, 0.5f, 0.5f);     //Color naranja
            GL.Vertex3(-0.05f, -0.4f, 0.0f); //Vértice 0
            GL.Vertex3(-0.05f, 0.0f, 0.0f);  //Vértice 1
            GL.Vertex3(-0.02f, 0.0f, 0.0f);  //Vértice 2
            GL.Vertex3(-0.02f, -0.4f, 0.0f); //Vértice 3
            GL.End();

            GL.Begin(BeginMode.Quads);       //Dibujamos la parte derecha con un cuadrado
            GL.Color3(1.0f, 1.0f, 1.0f);     //Color blanco
            GL.Vertex3(-0.02f, -0.4f, 0.0f);  //Vértice 0
            GL.Vertex3(-0.02f, 0.0f, 0.0f);  //Vértice 1
            GL.Vertex3(0.01f, 0.02f, -0.2f);  //Vértice 2
            GL.Vertex3(0.01f, -0.38f, -0.2f);   //Vértice 3
            GL.End();

            //Dibujamos la parte trasera con un cuadrado
            //Dibujamos la parte izquierda con un cuadrado

            GL.Flush();
        }

        public void dibujarPataDeIzq()
        {
            GL.Begin(BeginMode.Quads);       //Dibujamos la parte frontal con un cuadrado
            GL.Color3(1.0f, 0.5f, 0.5f);     //Color naranja
            GL.Vertex3(-0.47f, -0.4f, 0.0f); //Vértice 0
            GL.Vertex3(-0.47f, 0.0f, 0.0f);  //Vértice 1
            GL.Vertex3(-0.44f, 0.0f, -0.2f); //Vértice 2
            GL.Vertex3(-0.44f, -0.4f, 0.2f); //Vértice 3
            GL.End();

            GL.Begin(BeginMode.Quads);       //Dibujamos la parte derecha con un cuadrado
            GL.Color3(1.0f, 1.0f, 1.0f);     //Color blanco
            GL.Vertex3(-0.44f, -0.4f, 0.0f);  //Vértice 0
            GL.Vertex3(-0.44f, 0.0f, 0.0f);  //Vértice 1
            GL.Vertex3(-0.41f, 0.02f, -0.2f); //Vértice 2
            GL.Vertex3(-0.41f, -0.38f, -0.2f); //Vértice 3
            GL.End();

            //Dibujamos la parte trasera con un cuadrado
            //Dibujamos la parte izquierda con un cuadrado

            GL.Flush();
        }

        public void dibujarPataTraDer()
        {
            GL.Begin(BeginMode.Quads);       //Dibujamos la parte frontal con un cuadrado
            GL.Color3(1.0f, 0.5f, 0.5f);     //Color naranja
            GL.Vertex3(0.425f, 0.12f, -0.7f);  //Vértice 0
            GL.Vertex3(0.425f, 0.46f, -0.7f);  //Vértice 1
            GL.Vertex3(0.45f, 0.46f, -0.7f);  //Vértice 2
            GL.Vertex3(0.45f, 0.12f, -0.7f);  //Vértice 3
            GL.End();

            GL.Begin(BeginMode.Quads);       //Dibujamos la parte derecha con un cuadrado
            GL.Color3(1.0f, 1.0f, 1.0f);     //Color blanco
            GL.Vertex3(0.45f, 0.12f, -0.7f);  //Vértice 0
            GL.Vertex3(0.45f, 0.46f, -0.7f);  //Vértice 1
            GL.Vertex3(0.47f, 0.48f, -0.9f);  //Vértice 2
            GL.Vertex3(0.47f, 0.14f, -0.9f);  //Vértice 3
            GL.End();

            //Dibujamos la parte trasera con un cuadrado
            //Dibujamos la parte izquierda con un cuadrado
        }

        public void dibujarPataTraIzq()
        {
            GL.Begin(BeginMode.Quads);       //Dibujamos la parte frontal con un cuadrado
            GL.Color3(1.0f, 0.5f, 0.5f);     //Color naranja
            GL.Vertex3(-0.05f, 0.12f, -0.7f);  //Vértice 0
            GL.Vertex3(-0.05f, 0.46f, -0.7f);  //Vértice 1
            GL.Vertex3(-0.02f, 0.46f, -0.7f);  //Vértice 2
            GL.Vertex3(-0.02f, 0.12f, -0.7f);  //Vértice 3
            GL.End();

            GL.Begin(BeginMode.Quads);       //Dibujamos la parte derecha con un cuadrado
            GL.Color3(1.0f, 1.0f, 1.0f);     //Color blanco
            GL.Vertex3(-0.02f, 0.12f, -0.7f);  //Vértice 0
            GL.Vertex3(-0.02f, 0.46f, -0.7f);  //Vértice 1
            GL.Vertex3(0.0f, 0.48f, -0.9f);  //Vértice 2
            GL.Vertex3(0.0f, 0.14f, -0.9f);  //Vértice 3
            GL.End();

            //Dibujamos la parte trasera con un cuadrado
            //Dibujamos la parte izquierda con un cuadrado
        }
    }
}
