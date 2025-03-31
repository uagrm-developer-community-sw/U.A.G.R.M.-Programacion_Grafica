using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using crearFigruas3D.Models;
using System;
using System.Windows.Forms;
using System.Drawing;
using Figura3D_MVC.Controllers;
using OpenTK.Graphics;

namespace crearFigruas3D.Views
{
    public class GameView : GameWindow
    {
        private GameModel _model;
        private GameDraw _gameDraw;
        private CameraController _cameraController;  // Instancia de CameraController

        public GameView(GameModel model, int width, int height, string title)
            : base(width, height, GraphicsMode.Default, title)
        {
            try
            {
                _model = model;
                _gameDraw = new GameDraw(model);  // Instanciamos correctamente GameDraw
                _cameraController = new CameraController(); // Crear el controlador de la cámara
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la vista: " + ex.Message);
            }
        }

        // Sobrescribir el evento MouseWheel para manejar el zoom
        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            try
            {
                base.OnMouseWheel(e);
                _cameraController.HandleMouseWheel(e); // Delegar al CameraController
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al manejar el zoom: " + ex.Message);
            }
        }

        // Sobrescribir el evento de teclado para mover la cámara y la letra "U"
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            try
            {
                base.OnUpdateFrame(e);
                var keyboardState = Keyboard.GetState();

                // Delegamos el movimiento de la cámara y la letra "U" al CameraController
                _cameraController.HandleKeyboardMovement(keyboardState);
                _cameraController.HandleLetterMovement(keyboardState);

                // Actualizamos las transformaciones de la letra "U"
                _cameraController.ApplyLetterTransformations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el fotograma: " + ex.Message);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                GL.ClearColor(0.1f, 0.1f, 0.1f, 1.0f);
                GL.Enable(EnableCap.DepthTest);

                // Configurar la proyección
                GL.MatrixMode(MatrixMode.Projection);

                Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                    MathHelper.PiOver4,
                    Width / (float)Height,
                    0.1f,
                    100f
                );

                GL.LoadMatrix(ref projection);
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

                // Aplicamos las transformaciones de la cámara (como zoom y movimiento)
                _cameraController.ApplyCameraTransformations();



                // Usamos la instancia de GameDraw para dibujar las figuras
                if (_gameDraw != null)
                {
                    _gameDraw.Dibujar("LetraU");
                    _gameDraw.Dibujar("Ejes");
                }
                else
                {
                    MessageBox.Show("Error: _gameDraw no ha sido inicializado.");
                }

                // Actualizamos la rotación de los ejes
                _gameDraw.UpdateAxesRotation();

                // Incrementamos la rotación de los ejes
                float rotationXAxes = 0.0f; // Este valor debe ser controlado adecuadamente
                rotationXAxes += 0.1f;
                if (rotationXAxes >= 360.0f) rotationXAxes -= 360.0f;

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

                Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                    MathHelper.PiOver4,
                    Width / (float)Height,
                    0.1f,
                    100f
                );

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
