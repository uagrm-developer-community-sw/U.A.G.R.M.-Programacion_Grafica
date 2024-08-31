using OpenTK.Graphics;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    public class Floor
    {
        public static List<Face> getFaces()
        {
            List<Face> faces = new List<Face>();
            Color4 color = new Color4(0.7f, 0.6f, 0.9f, 0.6f);

            Face f1 = new Face(color);
            f1.AddVertex(30, 0, 30);
            f1.AddVertex(30, 0, -30);
            f1.AddVertex(-30, 0, -30);
            f1.AddVertex(-30, 0, 30);
            faces.Add(f1);

            return faces;
        }
    }
}
