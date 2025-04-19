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

        public void DibujarObjetosJson(List<ObjetoJsonDrawable> objetos, float scaleFactor = 0.5f)
        {
            foreach (var obj in objetos)
            {
                GL.PushMatrix();

                // Aplicar las transformaciones (traslación y rotación) y escalar los vértices
                TransformationUtils.ApplyTransformations(
                    obj.Posicion - obj.CentroDeMasa,
                    obj.Rotacion.X,
                    obj.Rotacion.Y
                );

                // Dibujar los vértices (puntos)
                GL.PointSize(5f);
                GL.Begin(PrimitiveType.Points);
                foreach (var v in obj.Modelo.Vertices)
                {
                    // Escalar las coordenadas de los vértices
                    float scaledX = v.X * scaleFactor;
                    float scaledY = v.Y * scaleFactor;
                    float scaledZ = v.Z * scaleFactor;

                    GL.Color3(1.0f, 1.0f, 0.0f);  // Color amarillo para los puntos
                    GL.Vertex3(scaledX, scaledY, scaledZ);
                }
                GL.End();

                // Dibujar las aristas (líneas entre los vértices)
                GL.Begin(PrimitiveType.Lines);  // Usamos 'Lines' para las aristas

                foreach (var edge in obj.Modelo.Edges)
                {
                    var vertex1 = obj.Modelo.Vertices[edge[0]];
                    var vertex2 = obj.Modelo.Vertices[edge[1]];

                    // Escalar las coordenadas de los vértices de las aristas
                    float scaledX1 = vertex1.X * scaleFactor;
                    float scaledY1 = vertex1.Y * scaleFactor;
                    float scaledZ1 = vertex1.Z * scaleFactor;
                    float scaledX2 = vertex2.X * scaleFactor;
                    float scaledY2 = vertex2.Y * scaleFactor;
                    float scaledZ2 = vertex2.Z * scaleFactor;

                    GL.Color3(1.0f, 1.0f, 1.0f);  // Color blanco para las aristas
                    GL.Vertex3(scaledX1, scaledY1, scaledZ1);
                    GL.Vertex3(scaledX2, scaledY2, scaledZ2);
                }

                GL.End();

                GL.PopMatrix();
            }
        }



    }
}