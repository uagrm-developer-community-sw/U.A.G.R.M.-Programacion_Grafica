using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Windows.Forms;
using System;

namespace Figura3D_MVC.Models
{
    public static class TransformationUtils
    {
        // Método para aplicar traslación (movimiento en los ejes X, Y, Z)
        public static void ApplyTranslation(Vector3 translation)
        {
            GL.Translate(translation.X, translation.Y, translation.Z);
        }

        // Método para aplicar rotación en los ejes X, Y y Z
        public static void ApplyRotation(float rotationX, float rotationY)
        {
            GL.Rotate(rotationX, 1.0f, 0.0f, 0.0f);  // Rotación sobre el eje X
            GL.Rotate(rotationY, 0.0f, 1.0f, 0.0f);  // Rotación sobre el eje Y
        }

        // Método para aplicar una transformación completa (traslación + rotación)
        public static void ApplyTransformations(Vector3 translation, float rotationX, float rotationY)
        {
            try
            {
                ApplyTranslation(translation);
                ApplyRotation(rotationX, rotationY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar la transformación: " + ex.Message);
            }
        }
    }
}
