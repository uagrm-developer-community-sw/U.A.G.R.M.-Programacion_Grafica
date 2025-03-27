using System;
using OpenTK;
using System.Collections.Generic;

namespace Figura3D_MVC.Models
{
    // La clase GeometryUtils es estática, por lo que se puede llamar sin necesidad de instanciarla
    internal static class GeometryUtils
    {
        // Método estático para calcular el centro de masa de una lista de vértices
        public static Vector3 CalculateCenterOfMass(List<Vector3> vertices)
        {
            Vector3 centerOfMass = new Vector3(0, 0, 0);

            // Sumar todas las posiciones de los vértices
            foreach (var vertex in vertices)
            {
                centerOfMass += vertex;
            }

            // Promediar las posiciones para obtener el centro de masa
            centerOfMass /= vertices.Count;

            return centerOfMass;
        }
    }
}
