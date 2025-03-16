using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace crearFigruas3D.Models
{
    public class AxesModel
    {
        // Método para calcular el centro de masa de los ejes
        public static Vector3 CalculateCenterOfMass()
        {
            // Vértices de los ejes (X, Y, Z)
            Vector3[] vertices = new Vector3[]
            {
                new Vector3(-1.5f, 0.0f, 0.0f),  // Eje X (inicio)
                new Vector3(1.5f, 0.0f, 0.0f),   // Eje X (fin)

                new Vector3(0.0f, -1.5f, 0.0f),  // Eje Y (inicio)
                new Vector3(0.0f, 1.5f, 0.0f),   // Eje Y (fin)

                new Vector3(0.0f, 0.0f, -1.5f),  // Eje Z (inicio)
                new Vector3(0.0f, 0.0f, 1.5f)    // Eje Z (fin)
            };

            // Calcular el centro de masa (promedio de las posiciones de los vértices)
            Vector3 centerOfMass = new Vector3(0, 0, 0);
            foreach (var vertex in vertices)
            {
                centerOfMass += vertex;
            }

            // Promediar las posiciones para obtener el centro de masa
            centerOfMass /= vertices.Length;

            // Retornar el centro de masa calculado
            return centerOfMass;
        }

        public static void DrawAxes()
        {
            GL.Begin(PrimitiveType.Lines);

            // Eje X - Rojo
            GL.Color3(1.0f, 0.0f, 0.0f);
            GL.Vertex3(-1.5f, 0.0f, 0.0f);
            GL.Vertex3(1.5f, 0.0f, 0.0f);

            // Eje Y - Verde
            GL.Color3(0.0f, 1.0f, 0.0f);
            GL.Vertex3(0.0f, -1.5f, 0.0f);
            GL.Vertex3(0.0f, 1.5f, 0.0f);

            // Eje Z - Azul
            GL.Color3(0.0f, 0.0f, 1.0f);
            GL.Vertex3(0.0f, 0.0f, -1.5f);
            GL.Vertex3(0.0f, 0.0f, 1.5f);

            GL.End();
        }


    }
}
