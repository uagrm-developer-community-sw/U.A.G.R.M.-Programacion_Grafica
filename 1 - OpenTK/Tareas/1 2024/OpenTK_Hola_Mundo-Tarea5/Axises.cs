using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace OpenTK_Hola_Mundo
{
    internal class Axises
    {
        public static void Draw(Vertex center, int longitude)
        {
            if (center == null)
                return;

            GL.Begin(BeginMode.Lines);
            GL.Color4(Color4.Cyan);
            GL.Vertex3(center.x, center.y, center.z);
            GL.Vertex3(center.x + longitude, center.y, center.z);
            GL.Color4(Color4.Magenta);
            GL.Vertex3(center.x, center.y, center.z);
            GL.Vertex3(center.x, center.y + longitude, center.z);
            GL.Color4(Color4.Yellow);
            GL.Vertex3(center.x, center.y, center.z);
            GL.Vertex3(center.x, center.y, center.z + longitude);
            GL.End();
        }

        public static void DrawFloor(Vertex center, int longitude)
        {
            if (center == null)
                return;

            int factor = longitude / 2;
            Color4 color = new Color4(0.7f, 0.6f, 0.9f, 0.6f);
            GL.Color4(color);
            GL.Begin(BeginMode.Quads);
            GL.Vertex3(-factor + center.x, 0.0f + center.y, -factor + center.z);
            GL.Vertex3(factor + center.x, 0.0f + center.y, -factor + center.z);
            GL.Vertex3(factor + center.x, 0.0f + center.y, factor + center.z);
            GL.Vertex3(-factor + center.x, 0.0f + center.y, factor + center.z);
            GL.End();
        }
    }
}
