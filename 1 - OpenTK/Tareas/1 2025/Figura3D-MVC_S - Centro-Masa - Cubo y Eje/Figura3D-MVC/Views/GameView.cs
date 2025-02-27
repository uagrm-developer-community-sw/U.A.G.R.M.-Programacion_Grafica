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

                // 1. Alejar la cámara para que el cubo y los ejes sean visibles
                GL.Translate(0.0f, 0.0f, -6.0f); // Desplazamos la cámara para ver bien la escena

                // 2. Dibujar los ejes (sin transformaciones de rotación o traslación aplicadas a ellos)
                GL.PushMatrix();
                _model.DrawAxisLines(); // Dibujar los ejes X, Y, Z
                GL.PopMatrix();

                // 3. Calcular el centro de masa del cubo
                float[] cubeCenterOfMass = _model.CalculateCubeCenterOfMass();

                // 4. Dibujar la línea hacia el centro de masa del cubo
                _model.DrawLineToCenterOfMass(cubeCenterOfMass);

                // 5. Dibujar la línea hacia el centro de masa de los ejes (sin transformar)
                float[] axisCenterOfMass = _model.CalculateAxisCenterOfMass(); // Los ejes siempre tienen el centro de masa en el origen
                _model.DrawLineToAxisCenterOfMass(axisCenterOfMass); // Esto dibuja una línea desde el origen hasta el centro de los ejes

                // Guardar el estado de la matriz antes de las transformaciones del cubo
                GL.PushMatrix();

                // 6. Dibujar el cubo, ya trasladado y rotado correctamente en el modelo
                _model.DrawCube();

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
