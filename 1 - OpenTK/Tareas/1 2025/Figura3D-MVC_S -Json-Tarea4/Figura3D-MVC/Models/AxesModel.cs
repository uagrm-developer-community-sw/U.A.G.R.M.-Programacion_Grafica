using Figura3D_MVC.Models;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Figura3D_MVC.Models
{
    public class AxesModel
    {
        // Método para calcular el centro de masa de los ejes
        public static Vector3 CalculateCenterOfMass()
        {
            // Vértices de los ejes (X, Y, Z)
            List<Vector3> vertices = new List<Vector3>
            {
                new Vector3(-1.5f, 0.0f, 0.0f),  // Eje X (inicio)
                new Vector3(1.5f, 0.0f, 0.0f),   // Eje X (fin)

                new Vector3(0.0f, -1.5f, 0.0f),  // Eje Y (inicio)
                new Vector3(0.0f, 1.5f, 0.0f),   // Eje Y (fin)

                new Vector3(0.0f, 0.0f, -1.5f),  // Eje Z (inicio)
                new Vector3(0.0f, 0.0f, 1.5f)    // Eje Z (fin)
            };

            // Llamamos a la función común para calcular el centro de masa
            return GeometryUtils.CalculateCenterOfMass(vertices);
        }

        // Método para dibujar los ejes, con parámetro de rotación
        public static void DrawAxes(float rotationX)
        {
            try
            {
                GL.PushMatrix();

                GL.Rotate(rotationX, 0.0f, 1.0f, 0.0f);

                GL.Begin(PrimitiveType.Lines);

                // Eje X - Rojo
                GL.Color3(1.0f, 0.0f, 0.0f);
                GL.Vertex3(-1.5f, 0.0f, 0.0f);
                GL.Vertex3(1.5f, 0.0f, 0.0f);

                // Eje Y - Verde
                GL.Color3(0.0f, 1.0f, 0.0f);
                GL.Vertex3(0.0f, -1.5f, 0.0f);
                GL.Vertex3(0.0f, 1.5f, 0.0f);

                // Eje Z - Azul
                GL.Color3(0.0f, 0.0f, 1.0f);
                GL.Vertex3(0.0f, 0.0f, -1.5f);
                GL.Vertex3(0.0f, 0.0f, 1.5f);

                GL.End();

                GL.PopMatrix();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dibujar los ejes: " + ex.Message);
            }
        }
    }
}

