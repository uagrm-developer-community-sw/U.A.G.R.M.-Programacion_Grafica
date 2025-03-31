using Figura3D_MVC.Models;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace crearFigruas3D.Models
{
    public class ULetterModel
    {
        private static float positionX = 0.0f;
        private static float positionY = 0.0f;

        // Método para mover la letra "U"
        public static void Move(float x, float y)
        {
            positionX = x;
            positionY = y;
        }

        // Método para calcular el centro de masa de la letra U
        public static Vector3 CalculateCenterOfMass()
        {
            // Vértices de la letra U
            List<Vector3> vertices = new List<Vector3>
            {
                new Vector3(-0.5f, -0.5f, 0.2f),
                new Vector3(-0.3f, -0.5f, 0.2f),
                new Vector3(-0.3f, 0.5f, 0.2f),
                new Vector3(-0.5f, 0.5f, 0.2f),

                new Vector3(0.3f, -0.5f, 0.2f),
                new Vector3(0.5f, -0.5f, 0.2f),
                new Vector3(0.5f, 0.5f, 0.2f),
                new Vector3(0.3f, 0.5f, 0.2f),

                new Vector3(-0.3f, -0.5f, 0.2f),
                new Vector3(0.3f, -0.5f, 0.2f),
                new Vector3(0.3f, -0.3f, 0.2f),
                new Vector3(-0.3f, -0.3f, 0.2f),

                new Vector3(-0.5f, 0.5f, 0.2f),
                new Vector3(-0.5f, 0.5f, -0.2f),
                new Vector3(-0.5f, -0.5f, -0.2f),
                new Vector3(-0.5f, -0.5f, 0.2f),

                new Vector3(-0.5f, -0.5f, -0.2f),
                new Vector3(-0.3f, -0.5f, -0.2f),
                new Vector3(-0.3f, 0.5f, -0.2f),
                new Vector3(-0.5f, 0.5f, -0.2f),

                new Vector3(0.3f, -0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, -0.2f),
                new Vector3(0.5f, 0.5f, -0.2f),
                new Vector3(0.3f, 0.5f, -0.2f),

                new Vector3(-0.3f, -0.5f, -0.2f),
                new Vector3(0.3f, -0.5f, -0.2f),
                new Vector3(0.3f, -0.3f, -0.2f),
                new Vector3(-0.3f, -0.3f, -0.2f),

                new Vector3(-0.5f, -0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, 0.2f),
                new Vector3(-0.5f, -0.5f, 0.2f),

                new Vector3(0.5f, 0.5f, 0.2f),
                new Vector3(0.5f, 0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, 0.2f),

                new Vector3(-0.5f, 0.5f, 0.2f),
                new Vector3(-0.3f, 0.5f, 0.2f),
                new Vector3(-0.3f, 0.5f, -0.2f),
                new Vector3(-0.5f, 0.5f, -0.2f),

                new Vector3(0.3f, 0.5f, 0.2f),
                new Vector3(0.5f, 0.5f, 0.2f),
                new Vector3(0.5f, 0.5f, -0.2f),
                new Vector3(0.3f, 0.5f, -0.2f),

                new Vector3(-0.3f, 0.5f, 0.2f),
                new Vector3(-0.3f, 0.5f, -0.2f),
                new Vector3(-0.3f, -0.5f, -0.2f),
                new Vector3(-0.3f, -0.5f, 0.2f),

                new Vector3(0.3f, 0.5f, 0.2f),
                new Vector3(0.3f, 0.5f, -0.2f),
                new Vector3(0.3f, -0.5f, -0.2f),
                new Vector3(0.3f, -0.5f, 0.2f)
            };

            // Llamamos a la función común para calcular el centro de masa
            return GeometryUtils.CalculateCenterOfMass(vertices);
        }

        // Método para dibujar la letra "U"
        public static void DrawU(float rotationX, float rotationY)
        {
            try
            {
                GL.PushMatrix();

                GL.Translate(positionX, positionY, 0.0f); // Usar la posición actual

                GL.Rotate(rotationX, 1.0f, 0.0f, 0.0f);
                GL.Rotate(rotationY, 0.0f, 1.0f, 0.0f);

                Vector3 centerOfMass = CalculateCenterOfMass();
                TransformationUtils.ApplyTransformations(centerOfMass, rotationX, rotationY);

                GL.Begin(PrimitiveType.Quads);

                GL.Color3(1.0f, 0.0f, 0.0f);
                GL.Vertex3(-0.5f, -0.5f, 0.2f);
                GL.Vertex3(-0.3f, -0.5f, 0.2f);
                GL.Vertex3(-0.3f, 0.5f, 0.2f);
                GL.Vertex3(-0.5f, 0.5f, 0.2f);

                GL.Color3(0.0f, 1.0f, 0.0f);
                GL.Vertex3(0.3f, -0.5f, 0.2f);
                GL.Vertex3(0.5f, -0.5f, 0.2f);
                GL.Vertex3(0.5f, 0.5f, 0.2f);
                GL.Vertex3(0.3f, 0.5f, 0.2f);

                GL.Color3(0.0f, 0.0f, 1.0f);
                GL.Vertex3(-0.3f, -0.5f, 0.2f);
                GL.Vertex3(0.3f, -0.5f, 0.2f);
                GL.Vertex3(0.3f, -0.3f, 0.2f);
                GL.Vertex3(-0.3f, -0.3f, 0.2f);

                GL.Color3(0.7f, 0.3f, 0.1f);
                GL.Vertex3(-0.5f, 0.5f, 0.2f);
                GL.Vertex3(-0.5f, 0.5f, -0.2f);
                GL.Vertex3(-0.5f, -0.5f, -0.2f);
                GL.Vertex3(-0.5f, -0.5f, 0.2f);

                GL.Color3(1.0f, 0.5f, 0.0f);
                GL.Vertex3(-0.5f, -0.5f, -0.2f);
                GL.Vertex3(-0.3f, -0.5f, -0.2f);
                GL.Vertex3(-0.3f, 0.5f, -0.2f);
                GL.Vertex3(-0.5f, 0.5f, -0.2f);

                GL.Color3(0.5f, 0.0f, 1.0f);
                GL.Vertex3(0.3f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, 0.5f, -0.2f);
                GL.Vertex3(0.3f, 0.5f, -0.2f);

                GL.Color3(1.0f, 0.8f, 0.0f);
                GL.Vertex3(-0.3f, -0.5f, -0.2f);
                GL.Vertex3(0.3f, -0.5f, -0.2f);
                GL.Vertex3(0.3f, -0.3f, -0.2f);
                GL.Vertex3(-0.3f, -0.3f, -0.2f);

                GL.Color3(0.4f, 0.4f, 0.4f);
                GL.Vertex3(-0.5f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, 0.2f);
                GL.Vertex3(-0.5f, -0.5f, 0.2f);

                GL.Color3(0.2f, 0.5f, 0.8f);
                GL.Vertex3(0.5f, 0.5f, 0.2f);
                GL.Vertex3(0.5f, 0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, 0.2f);

                GL.Color3(0.9f, 0.3f, 0.6f);
                GL.Vertex3(-0.5f, 0.5f, 0.2f);
                GL.Vertex3(-0.3f, 0.5f, 0.2f);
                GL.Vertex3(-0.3f, 0.5f, -0.2f);
                GL.Vertex3(-0.5f, 0.5f, -0.2f);

                GL.Color3(0.1f, 0.7f, 0.4f);
                GL.Vertex3(0.3f, 0.5f, 0.2f);
                GL.Vertex3(0.5f, 0.5f, 0.2f);
                GL.Vertex3(0.5f, 0.5f, -0.2f);
                GL.Vertex3(0.3f, 0.5f, -0.2f);

                GL.Color3(0.6f, 0.2f, 0.9f);
                GL.Vertex3(-0.3f, 0.5f, 0.2f);
                GL.Vertex3(-0.3f, 0.5f, -0.2f);
                GL.Vertex3(-0.3f, -0.5f, -0.2f);
                GL.Vertex3(-0.3f, -0.5f, 0.2f);

                GL.Color3(1.0f, 0.7f, 0.0f);
                GL.Vertex3(0.3f, 0.5f, 0.2f);
                GL.Vertex3(0.3f, 0.5f, -0.2f);
                GL.Vertex3(0.3f, -0.5f, -0.2f);
                GL.Vertex3(0.3f, -0.5f, 0.2f);

                GL.Color3(0.9f, 0.9f, 0.9f);
                GL.Vertex3(-0.3f, -0.30f, 0.2f);
                GL.Vertex3(0.3f, -0.30f, 0.2f);
                GL.Vertex3(0.3f, -0.30f, -0.2f);
                GL.Vertex3(-0.3f, -0.30f, -0.2f);

                GL.End();

                GL.PopMatrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dibujar la letra 'U': " + ex.Message);
            }
        }


    }
}
