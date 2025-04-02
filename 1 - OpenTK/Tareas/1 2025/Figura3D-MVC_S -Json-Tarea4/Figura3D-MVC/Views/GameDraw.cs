using OpenTK;
using OpenTK.Graphics.OpenGL;
using crearFigruas3D.Models;
using System;
using Figura3D_MVC.Models;

namespace crearFigruas3D.Views
{
    public class GameDraw
    {
        private GameModel _model;
        private float rotationXAxes = 0.0f;
        private float rotationSpeed = 0.1f;

        public GameDraw(GameModel model)
        {
            _model = model;
        }

        public void DibujarDesdeJson(JsonObjectModel objeto)
        {
            GL.PointSize(5f); // Tamaño de los puntos

            GL.Begin(PrimitiveType.Points);

            foreach (var vertex in objeto.Vertices)
            {
                GL.Color3(1.0f, 1.0f, 0.0f); // Amarillo
                GL.Vertex3(vertex.X, vertex.Y, vertex.Z);
            }

            GL.End();
        }



        // Método para dibujar la letra "U" y los ejes
        public void Dibujar(string figura)
        {
            GL.PushMatrix();

            if (figura == "LetraU")
            {
                // Calcular centro de masa
                Vector3 centerOfMassU = ULetterModel.CalculateCenterOfMass();
                Console.WriteLine("Centro de masa de la letra U: " + centerOfMassU);

                // Traslación y rotación para la letra "U"
                Vector3 translatedCenterOfMassU = new Vector3(centerOfMassU.X + 1.0f, centerOfMassU.Y + 1.0f, centerOfMassU.Z); // Desplazar la letra "U" en el eje X

                // Aplicar las transformaciones
                TransformationUtils.ApplyTransformations(translatedCenterOfMassU, _model.RotationX, _model.RotationY);

                // Dibujar letra "U" con las rotaciones
                ULetterModel.DrawU(_model.RotationX, _model.RotationY); // Pasando rotaciones

                //============================================================================//

                // Duplicar la letra "U" en otra ubicación
                //Vector3 translatedCenterOfMassU2 = new Vector3(centerOfMassU.X + 3.0f, centerOfMassU.Y + 1.0f, centerOfMassU.Z); // Desplazar la letra "U" duplicada

                // Aplicar las transformaciones para la segunda letra "U"
                //TransformationUtils.ApplyTransformations(translatedCenterOfMassU2, _model.RotationX, _model.RotationY);

                // Dibujar la segunda letra "U"
                //ULetterModel.DrawU(_model.RotationX, _model.RotationY); // Pasando las mismas rotaciones
            }
            else if (figura == "Ejes")
            {
                // Calcular centro de masa de los ejes
                Vector3 centerOfMassAxes = AxesModel.CalculateCenterOfMass();
                Console.WriteLine("Centro de masa de los ejes: " + centerOfMassAxes);

                // Traslación y rotación para los ejes
                TransformationUtils.ApplyTransformations(centerOfMassAxes, rotationXAxes, 0.0f); // Solo rotación en Y

                // Dibujar los ejes
                AxesModel.DrawAxes(rotationXAxes); // Pasando la rotación de los ejes
            }

            GL.PopMatrix();  // Restaurar la matriz
        }



        // Método para actualizar la rotación de los ejes
        public void UpdateAxesRotation()
        {
            rotationXAxes += rotationSpeed;
            if (rotationXAxes >= 360.0f) rotationXAxes -= 360.0f;
        }
    }
}
