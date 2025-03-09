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

                // 2. Dibujar los ejes y la línea al centro de masa (sin afectar los cubos)
                _model.DrawAxisLines();
                _model.DrawLineToCenterOfMass(_model.CalculateCubeCenterOfMass());

                // 3. Calcular el centro de masa del cubo
                float[] centerOfMass = _model.CalculateCubeCenterOfMass();

                // Dibujar el primer cubo
                GL.PushMatrix();
                _model.PositionCubeInPositiveQuadrant(); // Posicionar el cubo en el primer octante
                _model.DrawCube(); // Dibujar el primer cubo
                GL.PopMatrix();

                // Dibujar el segundo cubo desplazado
                GL.PushMatrix();
                GL.Translate(2.0f, 0.0f, 0.0f); // Mover el cubo 2 unidades en el eje X
                _model.DrawCube(); // Dibujar el cubo duplicado
                GL.PopMatrix();

                // Dibujar el tercer cubo desplazado
                GL.PushMatrix();
                GL.Translate(-2.0f, 2.0f, 0.0f); // Mover el cubo 2 unidades en X y 2 unidades en Y
                _model.DrawCube(); // Dibujar el cubo duplicado
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
