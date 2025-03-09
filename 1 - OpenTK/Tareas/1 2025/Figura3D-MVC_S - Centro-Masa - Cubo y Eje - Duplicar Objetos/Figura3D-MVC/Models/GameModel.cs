// Se importa el espacio de nombres 'OpenTK', que contiene la funcionalidad básica de OpenTK (Open Toolkit), una librería para gráficos 3D, entre otras.
using OpenTK;
// Se importa el espacio de nombres 'OpenTK.Graphics', que proporciona clases y métodos relacionados con gráficos 3D, como la configuración de la pantalla y el contexto de renderizado.
using OpenTK.Graphics;
// Se importa el espacio de nombres 'OpenTK.Graphics.OpenGL', que contiene las funciones necesarias para interactuar con OpenGL, una API de gráficos 3D.
using OpenTK.Graphics.OpenGL;
// Se importa el espacio de nombres 'System', que incluye tipos básicos de .NET como `Console`, `DateTime`, y otros elementos fundamentales para el sistema.
using System;

// Definición del espacio de nombres 'crearFigruas3D.Models', donde se maneja la lógica relacionada con los modelos del juego o aplicación.
namespace crearFigruas3D.Models
{
    // Definición de la clase 'GameModel', que se utiliza para manejar los datos del juego, como las rotaciones de la figura.

    public class GameModel
    {
        // Propiedades de rotación
        public float RotationX { get; set; } = 0.0f;
        public float RotationY { get; set; } = 0.0f;
        public float RotationZ { get; set; } = 0.0f;

        // Vértices del cubo
        private float[,] vertices = new float[,]
        {
            {-0.5f, -0.5f,  0.5f},
            { 0.5f, -0.5f,  0.5f},
            { 0.5f,  0.5f,  0.5f},
            {-0.5f,  0.5f,  0.5f},
            {-0.5f, -0.5f, -0.5f},
            { 0.5f, -0.5f, -0.5f},
            { 0.5f,  0.5f, -0.5f},
            {-0.5f,  0.5f, -0.5f}
        };

        // Método para calcular el centro de masa del cubo
        public float[] CalculateCubeCenterOfMass()
        {
            float centerX = 0f, centerY = 0f, centerZ = 0f;
            for (int i = 0; i < vertices.GetLength(0); i++)
            {
                centerX += vertices[i, 0];
                centerY += vertices[i, 1];
                centerZ += vertices[i, 2];
            }
            centerX /= vertices.GetLength(0);
            centerY /= vertices.GetLength(0);
            centerZ /= vertices.GetLength(0);

            return new float[] { centerX, centerY, centerZ };
        }

        

        // Método para aplicar la rotación en el sistema de coordenadas de su centro de masa
        public void ApplyRotation()
        {
            // 1. Calcular el centro de masa del cubo
            float[] centerOfMass = CalculateCubeCenterOfMass();

            // 2. Trasladar el cubo al centro de masa
            GL.Translate(centerOfMass[0], centerOfMass[1], centerOfMass[2]);

            // 3. Realizar la rotación en torno al centro de masa
            GL.Rotate(RotationX, 1.0f, 0.0f, 0.0f); // Rotación sobre el eje X
            GL.Rotate(RotationY, 0.0f, 1.0f, 0.0f); // Rotación sobre el eje Y
            GL.Rotate(RotationZ, 0.0f, 0.0f, 1.0f); // Rotación sobre el eje Z

            // 4. Volver a la posición original después de la rotación
            GL.Translate(-centerOfMass[0], -centerOfMass[1], -centerOfMass[2]);
        }

        // Método para mover el cubo al cuadrante positivo
        public void PositionCubeInPositiveQuadrant()
        {
            float[] centerOfMass = CalculateCubeCenterOfMass();

            // Calcular cuánto hay que mover el cubo para que su centro de masa esté en el primer octante
            float offsetX = (centerOfMass[0] < 0) ? Math.Abs(centerOfMass[0]) + 0.5f : 0.5f;
            float offsetY = (centerOfMass[1] < 0) ? Math.Abs(centerOfMass[1]) + 0.5f : 0.5f;
            float offsetZ = (centerOfMass[2] < 0) ? Math.Abs(centerOfMass[2]) + 0.5f : 0.5f;

            GL.Translate(offsetX, offsetY, offsetZ);
        }

        // Método para dibujar el cubo
        public void DrawCube()
        {
            // 1. Trasladamos y rotamos el cubo en el centro de masa
            ApplyRotation();

            // 2. Dibujar el cubo
            GL.Begin(PrimitiveType.Quads);

            // --- Dibujar las caras del cubo ---
            // Cara frontal (roja)
            GL.Color3(1.0f, 0.0f, 0.0f);
            GL.Vertex3(-0.25f, -0.25f, 0.25f);
            GL.Vertex3(0.25f, -0.25f, 0.25f);
            GL.Vertex3(0.25f, 0.25f, 0.25f);
            GL.Vertex3(-0.25f, 0.25f, 0.25f);

            // Cara trasera (verde)
            GL.Color3(0.0f, 1.0f, 0.0f);
            GL.Vertex3(-0.25f, -0.25f, -0.25f);
            GL.Vertex3(0.25f, -0.25f, -0.25f);
            GL.Vertex3(0.25f, 0.25f, -0.25f);
            GL.Vertex3(-0.25f, 0.25f, -0.25f);

            // Cara izquierda (azul)
            GL.Color3(0.0f, 0.0f, 1.0f);
            GL.Vertex3(-0.25f, -0.25f, -0.25f);
            GL.Vertex3(-0.25f, -0.25f, 0.25f);
            GL.Vertex3(-0.25f, 0.25f, 0.25f);
            GL.Vertex3(-0.25f, 0.25f, -0.25f);

            // Cara derecha (amarilla)
            GL.Color3(1.0f, 1.0f, 0.0f);
            GL.Vertex3(0.25f, -0.25f, -0.25f);
            GL.Vertex3(0.25f, -0.25f, 0.25f);
            GL.Vertex3(0.25f, 0.25f, 0.25f);
            GL.Vertex3(0.25f, 0.25f, -0.25f);

            // Cara superior (magenta)
            GL.Color3(1.0f, 0.0f, 1.0f);
            GL.Vertex3(-0.25f, 0.25f, -0.25f);
            GL.Vertex3(0.25f, 0.25f, -0.25f);
            GL.Vertex3(0.25f, 0.25f, 0.25f);
            GL.Vertex3(-0.25f, 0.25f, 0.25f);

            // Cara inferior (cian)
            GL.Color3(0.0f, 1.0f, 1.0f);
            GL.Vertex3(-0.25f, -0.25f, -0.25f);
            GL.Vertex3(0.25f, -0.25f, -0.25f);
            GL.Vertex3(0.25f, -0.25f, 0.25f);
            GL.Vertex3(-0.25f, -0.25f, 0.25f);

            GL.End();
        }





        // Método para dibujar la línea hacia el centro de masa del cubo
        public void DrawLineToCenterOfMass(float[] centerOfMass)
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0.0f, 0.0f, 0.0f);  // Origen (punto de inicio)
            GL.Vertex3(centerOfMass[0], centerOfMass[1], centerOfMass[2]); // Centro de masa del cubo
            GL.End();
        }

        // Método para dibujar la línea hacia el centro de masa de los ejes (diferente al cubo)
        public void DrawLineToAxisCenterOfMass(float[] axisCenterOfMass)
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0.0f, 0.0f, 0.0f);  // Origen de los ejes (punto de inicio)
            GL.Vertex3(axisCenterOfMass[0], axisCenterOfMass[1], axisCenterOfMass[2]); // Centro de masa de los ejes
            GL.End();
        }


        // Método para calcular el centro de masa de los ejes
        public float[] CalculateAxisCenterOfMass()
        {
            // Los ejes X, Y y Z son líneas, así que el centro de masa es el punto medio de esas líneas.
            // El centro de masa de la línea en el eje X es (0.0f, 0.0f, 0.0f), y lo mismo para Y y Z.

            // En este caso, el centro de masa de cada eje se considera el origen.
            // Si los ejes fueran más largos, calculamos el punto medio de cada eje.
            return new float[] { 0.0f, 0.0f, 0.0f };
        }

        // Método para dibujar los ejes
        public void DrawAxisLines()
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1.0f, 1.0f, 1.0f); // Color blanco

            // Línea en el eje X
            GL.Vertex3(-10.0f, 0.0f, 0.0f);
            GL.Vertex3(10.0f, 0.0f, 0.0f);

            // Línea en el eje Y
            GL.Vertex3(0.0f, -10.0f, 0.0f);
            GL.Vertex3(0.0f, 10.0f, 0.0f);

            // Línea en el eje Z
            GL.Vertex3(0.0f, 0.0f, -10.0f);
            GL.Vertex3(0.0f, 0.0f, 10.0f);

            GL.End();
        }
    }
}

