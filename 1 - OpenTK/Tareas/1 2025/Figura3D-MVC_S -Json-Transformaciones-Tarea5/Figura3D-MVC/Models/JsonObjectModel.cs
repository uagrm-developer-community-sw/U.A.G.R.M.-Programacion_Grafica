using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura3D_MVC.Models
{
    public class JsonVertex
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }

    public class JsonObjectModel
    {
        public string Nombre { get; set; }
        public List<JsonVertex> Vertices { get; set; }
        public List<List<int>> Indices { get; set; }  // Representa los índices de los triángulos
        public List<List<int>> Edges { get; set; }    // Representa los bordes entre vértices
    }
}
