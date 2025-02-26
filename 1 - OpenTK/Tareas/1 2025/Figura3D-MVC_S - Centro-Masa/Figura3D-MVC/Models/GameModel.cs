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
        public float RotationX { get; set; } = 0.0f;
        public float RotationY { get; set; } = 0.0f;
        public float RotationZ { get; set; } = 0.0f;


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

        public float[] CalculateCenterOfMass()
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

        public void PositionCubeInPositiveQuadrant()
        {
            float[] centerOfMass = CalculateCenterOfMass();

            // Calcular cuánto hay que mover el cubo para que su centro de masa esté en el primer octante
            float offsetX = (centerOfMass[0] < 0) ? Math.Abs(centerOfMass[0]) + 0.5f : 0.5f;
            float offsetY = (centerOfMass[1] < 0) ? Math.Abs(centerOfMass[1]) + 0.5f : 0.5f;
            float offsetZ = (centerOfMass[2] < 0) ? Math.Abs(centerOfMass[2]) + 0.5f : 0.5f;

            GL.Translate(offsetX, offsetY, offsetZ);
        }






        public void DrawLineToCenterOfMass()
        {
            float[] centerOfMass = CalculateCenterOfMass();
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0.0f, 0.0f, 0.0f);
            GL.Vertex3(centerOfMass[0], centerOfMass[1], centerOfMass[2]);
            GL.End();
        }

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
