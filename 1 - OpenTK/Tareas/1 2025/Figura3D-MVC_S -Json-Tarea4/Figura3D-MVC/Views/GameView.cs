using OpenTK;
using OpenTK.Input;
using crearFigruas3D.Models;
using System;
using System.Windows.Forms;
using Figura3D_MVC.Controllers;
using OpenTK.Graphics;
using Figura3D_MVC.Models;
using Figura3D_MVC.Models.Utils;

namespace crearFigruas3D.Views
{
    public class GameView : GameWindow
    {
        private GameModel _model;
        private GameDraw _gameDraw;
        private CameraController _cameraController;

        private JsonObjectModel _objetoJson;

        public GameView(GameModel model, int width, int height, string title)
            : base(width, height, GraphicsMode.Default, title)
        {
            try
            {
                _model = model;
                _gameDraw = new GameDraw(model);
                _cameraController = new CameraController();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la vista: " + ex.Message);
            }
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            try
            {
                base.OnMouseWheel(e);
                _cameraController.HandleMouseWheel(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al manejar el zoom: " + ex.Message);
            }
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            try
            {
                base.OnUpdateFrame(e);
                var keyboardState = Keyboard.GetState();

                _cameraController.HandleKeyboardMovement(keyboardState);
                _cameraController.HandleLetterMovement(keyboardState);

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
                _gameDraw.InitializeGraphics(Width, Height);

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

                _gameDraw.BeginDraw();

                _cameraController.ApplyCameraTransformations();

                _gameDraw.Dibujar("LetraU");
                _gameDraw.Dibujar("Ejes");

                _gameDraw.DibujarObjetosJson(_model.ObjetosJson);




                _gameDraw.UpdateAxesRotation();

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

                _gameDraw.Resize(Width, Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al redimensionar la ventana: " + ex.Message);
            }
        }

        public void RenderFromJson(JsonObjectModel objetoJson)
        {
            try
            {
                _objetoJson = objetoJson;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al renderizar el objeto JSON: " + ex.Message);
            }
        }
    }
} 