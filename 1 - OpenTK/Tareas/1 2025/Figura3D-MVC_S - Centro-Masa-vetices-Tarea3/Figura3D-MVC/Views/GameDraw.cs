using OpenTK;
using OpenTK.Graphics.OpenGL;
using crearFigruas3D.Models;
using System;

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
                GL.Translate(centerOfMassU.X + 1.0f, centerOfMassU.Y + 1.0f, centerOfMassU.Z + 1.0f);
                GL.Rotate(_model.RotationX, 1.0f, 0.0f, 0.0f);
                GL.Rotate(_model.RotationY, 0.0f, 1.0f, 0.0f);

                // Dibujar letra "U"
                ULetterModel.DrawU();
            }
            else if (figura == "Ejes")
            {
                // Calcular centro de masa de los ejes
                Vector3 centerOfMassAxes = AxesModel.CalculateCenterOfMass();
                Console.WriteLine("Centro de masa de los ejes: " + centerOfMassAxes);

                // Traslación y rotación para los ejes
                GL.Translate(-centerOfMassAxes.X, -centerOfMassAxes.Y, -centerOfMassAxes.Z);
                GL.Rotate(rotationXAxes, 0.0f, 1.0f, 0.0f);

                // Dibujar los ejes
                AxesModel.DrawAxes();
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
