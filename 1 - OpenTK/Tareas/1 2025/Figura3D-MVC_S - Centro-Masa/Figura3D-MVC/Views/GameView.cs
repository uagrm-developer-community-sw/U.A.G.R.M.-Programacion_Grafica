// Espacios de nombres necesarios para OpenTK y la aplicación
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using crearFigruas3D.Models;
using System;
using System.Windows.Forms;

namespace crearFigruas3D.Views
{
    public class GameView : GameWindow
    {
        private GameModel _model; // Modelo que almacena datos y transformaciones del cubo

        public GameView(GameModel model, int width, int height, string title)
            : base(width, height, GraphicsMode.Default, title)
        {
            try
            {
                _model = model;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la vista: " + ex.Message);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                GL.ClearColor(0.1f, 0.1f, 0.1f, 1.0f); // Color de fondo
                GL.Enable(EnableCap.DepthTest); // Habilitar test de profundidad
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ventana: " + ex.Message);
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            try
            {
                base.OnRenderFrame(e);
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadIdentity();

                // 1. Alejar la cámara
                GL.Translate(0.0f, 0.0f, -6.0f);

                // 2. Dibujar los ejes y la línea al centro de masa (sin afectar el cubo)
                _model.DrawAxisLines();
                _model.DrawLineToCenterOfMass();

                // 3. Calcular el centro de masa del cubo
                float[] centerOfMass = _model.CalculateCenterOfMass();

                // Guardar el estado de la matriz antes de transformar el cubo
                GL.PushMatrix();

                // 4. Trasladar el cubo a su centro antes de rotar
                GL.Translate(centerOfMass[0], centerOfMass[1], centerOfMass[2]);

                // 5. Aplicar la rotación del cubo
                GL.Rotate(_model.RotationX, 1.0f, 0.0f, 0.0f);
                GL.Rotate(_model.RotationY, 0.0f, 1.0f, 0.0f);
                GL.Rotate(_model.RotationZ, 0.0f, 0.0f, 1.0f);

                // 6. Mover el cubo al cuadrante positivo
                _model.PositionCubeInPositiveQuadrant();

                // 7. Regresar el cubo a su posición original después de la rotación
                GL.Translate(-centerOfMass[0], -centerOfMass[1], -centerOfMass[2]);

                // 8. Dibujar el cubo
                GL.Begin(PrimitiveType.Quads);

                // --- Dibujar las caras del cubo ---
                // Cara frontal (roja)
                GL.Color3(1.0f, 0.0f, 0.0f);
                GL.Vertex3(-0.25f, -0.25f, 0.25f);
                GL.Vertex3(0.25f, -0.25f, 0.25f);
                GL.Vertex3(0.25f, 0.25f, 0.25f);
                GL.Vertex3(-0.25f, 0.25f, 0.25f);

                // Cara trasera (verde)
                GL.Color3(0.0f, 1.0f, 0.0f);
                GL.Vertex3(-0.25f, -0.25f, -0.25f);
                GL.Vertex3(0.25f, -0.25f, -0.25f);
                GL.Vertex3(0.25f, 0.25f, -0.25f);
                GL.Vertex3(-0.25f, 0.25f, -0.25f);

                // Cara izquierda (azul)
                GL.Color3(0.0f, 0.0f, 1.0f);
                GL.Vertex3(-0.25f, -0.25f, -0.25f);
                GL.Vertex3(-0.25f, -0.25f, 0.25f);
                GL.Vertex3(-0.25f, 0.25f, 0.25f);
                GL.Vertex3(-0.25f, 0.25f, -0.25f);

                // Cara derecha (amarilla)
                GL.Color3(1.0f, 1.0f, 0.0f);
                GL.Vertex3(0.25f, -0.25f, -0.25f);
                GL.Vertex3(0.25f, -0.25f, 0.25f);
                GL.Vertex3(0.25f, 0.25f, 0.25f);
                GL.Vertex3(0.25f, 0.25f, -0.25f);

                // Cara superior (magenta)
                GL.Color3(1.0f, 0.0f, 1.0f);
                GL.Vertex3(-0.25f, 0.25f, -0.25f);
                GL.Vertex3(0.25f, 0.25f, -0.25f);
                GL.Vertex3(0.25f, 0.25f, 0.25f);
                GL.Vertex3(-0.25f, 0.25f, 0.25f);

                // Cara inferior (cian)
                GL.Color3(0.0f, 1.0f, 1.0f);
                GL.Vertex3(-0.25f, -0.25f, -0.25f);
                GL.Vertex3(0.25f, -0.25f, -0.25f);
                GL.Vertex3(0.25f, -0.25f, 0.25f);
                GL.Vertex3(-0.25f, -0.25f, 0.25f);

                GL.End();

                // Restaurar la matriz original para evitar afectar otras partes de la escena
                GL.PopMatrix();

                // Intercambiar buffers para mostrar el renderizado
                SwapBuffers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al renderizar el fotograma: " + ex.Message);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            try
            {
                base.OnResize(e);
                GL.Viewport(0, 0, Width, Height);

                Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 0.1f, 100f);
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadMatrix(ref projection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al redimensionar la ventana: " + ex.Message);
            }
        }
    }
}
