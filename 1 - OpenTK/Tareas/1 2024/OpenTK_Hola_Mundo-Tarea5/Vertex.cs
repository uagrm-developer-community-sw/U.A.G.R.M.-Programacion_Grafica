using Newtonsoft.Json;

namespace OpenTK_Hola_Mundo
{
    public class Vertex
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Vertex(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
