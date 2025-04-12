using System.Collections.Generic;
using OpenTK;

namespace crearFigruas3D.Models
{
    public class GameState
    {
        public List<ObjetoJsonGuardado> Objetos { get; set; } = new List<ObjetoJsonGuardado>();
    }

    public class ObjetoJsonGuardado
    {
        public string Nombre { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float RotX { get; set; }
        public float RotY { get; set; }
    }
}
