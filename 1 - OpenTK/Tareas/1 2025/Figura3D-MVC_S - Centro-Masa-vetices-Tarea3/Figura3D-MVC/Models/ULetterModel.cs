using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace crearFigruas3D.Models
{
    public class ULetterModel
    {
        // Método para calcular el centro de masa de la letra U
        public static Vector3 CalculateCenterOfMass()
        {
            // Vértices de la letra U
            Vector3[] vertices = new Vector3[]
            {
                new Vector3(-0.5f, -0.5f, 0.2f),
                new Vector3(-0.3f, -0.5f, 0.2f),
                new Vector3(-0.3f, 0.5f, 0.2f),
                new Vector3(-0.5f, 0.5f, 0.2f),

                new Vector3(0.3f, -0.5f, 0.2f),
                new Vector3(0.5f, -0.5f, 0.2f),
                new Vector3(0.5f, 0.5f, 0.2f),
                new Vector3(0.3f, 0.5f, 0.2f),

                new Vector3(-0.3f, -0.5f, 0.2f),
                new Vector3(0.3f, -0.5f, 0.2f),
                new Vector3(0.3f, -0.3f, 0.2f),
                new Vector3(-0.3f, -0.3f, 0.2f),

                new Vector3(-0.5f, 0.5f, 0.2f),
                new Vector3(-0.5f, 0.5f, -0.2f),
                new Vector3(-0.5f, -0.5f, -0.2f),
                new Vector3(-0.5f, -0.5f, 0.2f),

                new Vector3(-0.5f, -0.5f, -0.2f),
                new Vector3(-0.3f, -0.5f, -0.2f),
                new Vector3(-0.3f, 0.5f, -0.2f),
                new Vector3(-0.5f, 0.5f, -0.2f),

                new Vector3(0.3f, -0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, -0.2f),
                new Vector3(0.5f, 0.5f, -0.2f),
                new Vector3(0.3f, 0.5f, -0.2f),

                new Vector3(-0.3f, -0.5f, -0.2f),
                new Vector3(0.3f, -0.5f, -0.2f),
                new Vector3(0.3f, -0.3f, -0.2f),
                new Vector3(-0.3f, -0.3f, -0.2f),

                new Vector3(-0.5f, -0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, 0.2f),
                new Vector3(-0.5f, -0.5f, 0.2f),

                new Vector3(0.5f, 0.5f, 0.2f),
                new Vector3(0.5f, 0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, -0.2f),
                new Vector3(0.5f, -0.5f, 0.2f),

                new Vector3(-0.5f, 0.5f, 0.2f),
                new Vector3(-0.3f, 0.5f, 0.2f),
                new Vector3(-0.3f, 0.5f, -0.2f),
                new Vector3(-0.5f, 0.5f, -0.2f),

                new Vector3(0.3f, 0.5f, 0.2f),
                new Vector3(0.5f, 0.5f, 0.2f),
                new Vector3(0.5f, 0.5f, -0.2f),
                new Vector3(0.3f, 0.5f, -0.2f),

                new Vector3(-0.3f, 0.5f, 0.2f),
                new Vector3(-0.3f, 0.5f, -0.2f),
                new Vector3(-0.3f, -0.5f, -0.2f),
                new Vector3(-0.3f, -0.5f, 0.2f),

                new Vector3(0.3f, 0.5f, 0.2f),
                new Vector3(0.3f, 0.5f, -0.2f),
                new Vector3(0.3f, -0.5f, -0.2f),
                new Vector3(0.3f, -0.5f, 0.2f)
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

            // Traslación para poner el centro de masa en (0,0,0) - No necesario si ya está centrado
            // GL.Translate(-centerOfMass.X, -centerOfMass.Y, -centerOfMass.Z);

            

            // Dibujar la letra U
        }

        public static void DrawU()
        {


            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0f, 0.0f, 0.0f);
            GL.Vertex3(-0.5f, -0.5f, 0.2f);
            GL.Vertex3(-0.3f, -0.5f, 0.2f);
            GL.Vertex3(-0.3f, 0.5f, 0.2f);
            GL.Vertex3(-0.5f, 0.5f, 0.2f);

            GL.Color3(0.0f, 1.0f, 0.0f);
            GL.Vertex3(0.3f, -0.5f, 0.2f);
            GL.Vertex3(0.5f, -0.5f, 0.2f);
            GL.Vertex3(0.5f, 0.5f, 0.2f);
            GL.Vertex3(0.3f, 0.5f, 0.2f);

            GL.Color3(0.0f, 0.0f, 1.0f);
            GL.Vertex3(-0.3f, -0.5f, 0.2f);
            GL.Vertex3(0.3f, -0.5f, 0.2f);
            GL.Vertex3(0.3f, -0.3f, 0.2f);
            GL.Vertex3(-0.3f, -0.3f, 0.2f);

            GL.Color3(0.7f, 0.3f, 0.1f);
            GL.Vertex3(-0.5f, 0.5f, 0.2f);
            GL.Vertex3(-0.5f, 0.5f, -0.2f);
            GL.Vertex3(-0.5f, -0.5f, -0.2f);
            GL.Vertex3(-0.5f, -0.5f, 0.2f);

            GL.Color3(1.0f, 0.5f, 0.0f);
            GL.Vertex3(-0.5f, -0.5f, -0.2f);
            GL.Vertex3(-0.3f, -0.5f, -0.2f);
            GL.Vertex3(-0.3f, 0.5f, -0.2f);
            GL.Vertex3(-0.5f, 0.5f, -0.2f);

            GL.Color3(0.5f, 0.0f, 1.0f);
            GL.Vertex3(0.3f, -0.5f, -0.2f);
            GL.Vertex3(0.5f, -0.5f, -0.2f);
            GL.Vertex3(0.5f, 0.5f, -0.2f);
            GL.Vertex3(0.3f, 0.5f, -0.2f);

            GL.Color3(1.0f, 0.8f, 0.0f);
            GL.Vertex3(-0.3f, -0.5f, -0.2f);
            GL.Vertex3(0.3f, -0.5f, -0.2f);
            GL.Vertex3(0.3f, -0.3f, -0.2f);
            GL.Vertex3(-0.3f, -0.3f, -0.2f);

            GL.Color3(0.4f, 0.4f, 0.4f);
            GL.Vertex3(-0.5f, -0.5f, -0.2f);
            GL.Vertex3(0.5f, -0.5f, -0.2f);
            GL.Vertex3(0.5f, -0.5f, 0.2f);
            GL.Vertex3(-0.5f, -0.5f, 0.2f);

            GL.Color3(0.2f, 0.5f, 0.8f);
            GL.Vertex3(0.5f, 0.5f, 0.2f);
            GL.Vertex3(0.5f, 0.5f, -0.2f);
            GL.Vertex3(0.5f, -0.5f, -0.2f);
            GL.Vertex3(0.5f, -0.5f, 0.2f);

            GL.Color3(0.9f, 0.3f, 0.6f);
            GL.Vertex3(-0.5f, 0.5f, 0.2f);
            GL.Vertex3(-0.3f, 0.5f, 0.2f);
            GL.Vertex3(-0.3f, 0.5f, -0.2f);
            GL.Vertex3(-0.5f, 0.5f, -0.2f);

            GL.Color3(0.1f, 0.7f, 0.4f);
            GL.Vertex3(0.3f, 0.5f, 0.2f);
            GL.Vertex3(0.5f, 0.5f, 0.2f);
            GL.Vertex3(0.5f, 0.5f, -0.2f);
            GL.Vertex3(0.3f, 0.5f, -0.2f);

            GL.Color3(0.6f, 0.2f, 0.9f);
            GL.Vertex3(-0.3f, 0.5f, 0.2f);
            GL.Vertex3(-0.3f, 0.5f, -0.2f);
            GL.Vertex3(-0.3f, -0.5f, -0.2f);
            GL.Vertex3(-0.3f, -0.5f, 0.2f);

            GL.Color3(1.0f, 0.7f, 0.0f);
            GL.Vertex3(0.3f, 0.5f, 0.2f);
            GL.Vertex3(0.3f, 0.5f, -0.2f);
            GL.Vertex3(0.3f, -0.5f, -0.2f);
            GL.Vertex3(0.3f, -0.5f, 0.2f);

            GL.Color3(0.9f, 0.9f, 0.9f);
            GL.Vertex3(-0.3f, -0.30f, 0.2f);
            GL.Vertex3(0.3f, -0.30f, 0.2f);
            GL.Vertex3(0.3f, -0.30f, -0.2f);
            GL.Vertex3(-0.3f, -0.30f, -0.2f);

            GL.End();

            
        }

        
    }
}
