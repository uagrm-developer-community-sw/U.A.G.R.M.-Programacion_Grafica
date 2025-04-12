using Figura3D_MVC.Models;
using OpenTK;
using System.Collections.Generic;

namespace crearFigruas3D.Models
{
    public class ObjetoJsonDrawable
    {
        public JsonObjectModel Modelo { get; set; }
        public Vector3 Posicion { get; set; } = Vector3.Zero;
        public Vector3 Rotacion { get; set; } = Vector3.Zero;
        public Vector3 CentroDeMasa { get; set; }

        public ObjetoJsonDrawable(JsonObjectModel modelo)
        {
            Modelo = modelo;
            CentroDeMasa = CalcularCentroDeMasa(modelo.Vertices);
        }

        private Vector3 CalcularCentroDeMasa(List<JsonVertex> vertices)
        {
            float sumX = 0, sumY = 0, sumZ = 0;
            foreach (var v in vertices)
            {
                sumX += v.X;
                sumY += v.Y;
                sumZ += v.Z;
            }

            return new Vector3(sumX / vertices.Count, sumY / vertices.Count, sumZ / vertices.Count);
        }
    }
}
