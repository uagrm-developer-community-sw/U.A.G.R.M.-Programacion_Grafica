using System;
using OpenTK;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Figura3D_MVC.Models
{
    // La clase GeometryUtils es estática, por lo que se puede llamar sin necesidad de instanciarla
    internal static class GeometryUtils
    {
        // Método estático para calcular el centro de masa de una lista de vértices
        public static Vector3 CalculateCenterOfMass(List<Vector3> vertices)
        {
            try
            {
                Vector3 centerOfMass = new Vector3(0, 0, 0);

                foreach (var vertex in vertices)
                {
                    centerOfMass += vertex;
                }

                centerOfMass /= vertices.Count;

                return centerOfMass;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el centro de masa: " + ex.Message);
                return Vector3.Zero;  // Devuelve un valor predeterminado en caso de error
            }
        }
    }
}
