using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura3D_MVC.Models
{
    public class JsonObjectModel
    {
        public string Nombre { get; set; }
        public List<JsonVertex> Vertices { get; set; }

        public JsonVertex CentroDeMasa { get; set; }  // Agregado para almacenar el centro de masa
    }

    public class JsonVertex
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }



    
}
