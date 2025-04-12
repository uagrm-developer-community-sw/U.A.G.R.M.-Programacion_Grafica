using OpenTK;
using OpenTK.Graphics.OpenGL;
using crearFigruas3D.Models;
using System;
using Figura3D_MVC.Models;
using System.Diagnostics;
using System.Collections.Generic;

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
            GL.PointSize(5f);

            GL.Begin(PrimitiveType.Points);

            foreach (var vertex in objeto.Vertices)
            {
                GL.Color3(1.0f, 1.0f, 0.0f);
                GL.Vertex3(vertex.X, vertex.Y, vertex.Z);
            }

            GL.End();
        }

        public void Dibujar(string figura)
        {
            GL.PushMatrix();

            if (figura == "LetraU")
            {
                Vector3 centerOfMassU = ULetterModel.CalculateCenterOfMass();
                Debug.WriteLine("Centro de masa de la letra U: " + centerOfMassU);

                Vector3 translatedCenterOfMassU = new Vector3(centerOfMassU.X + 1.0f, centerOfMassU.Y + 1.0f, centerOfMassU.Z);

                TransformationUtils.ApplyTransformations(translatedCenterOfMassU, _model.RotationX, _model.RotationY);

                ULetterModel.DrawU(_model.RotationX, _model.RotationY);
            }
            else if (figura == "Ejes")
            {
                Vector3 centerOfMassAxes = AxesModel.CalculateCenterOfMass();
                Console.WriteLine("Centro de masa de los ejes: " + centerOfMassAxes);

                TransformationUtils.ApplyTransformations(centerOfMassAxes, rotationXAxes, 0.0f);

                AxesModel.DrawAxes(rotationXAxes);
            }

            GL.PopMatrix();
        }

        public void UpdateAxesRotation()
        {
            rotationXAxes += rotationSpeed;
            if (rotationXAxes >= 360.0f) rotationXAxes -= 360.0f;
        }

        public void BeginDraw()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        }

        public void Resize(int width, int height)
        {
            GL.Viewport(0, 0, width, height);

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4,
                width / (float)height,
                0.1f,
                100f
            );

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        public void InitializeGraphics(int width, int height)
        {
            GL.ClearColor(0.1f, 0.1f, 0.1f, 1.0f);
            GL.Enable(EnableCap.DepthTest);

            GL.MatrixMode(MatrixMode.Projection);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, width / (float)height, 0.1f, 100f);
            GL.LoadMatrix(ref projection);
        }

        public void DibujarObjetosJson(List<ObjetoJsonDrawable> objetos)
        {
            foreach (var obj in objetos)
            {
                GL.PushMatrix();

                TransformationUtils.ApplyTransformations(
                    obj.Posicion - obj.CentroDeMasa,
                    obj.Rotacion.X,
                    obj.Rotacion.Y
                );

                GL.PointSize(5f);
                GL.Begin(PrimitiveType.Points);
                foreach (var v in obj.Modelo.Vertices)
                {
                    GL.Color3(1.0f, 1.0f, 0.0f);
                    GL.Vertex3(v.X, v.Y, v.Z);
                }
                GL.End();

                GL.PopMatrix();
            }
        }

    }
}