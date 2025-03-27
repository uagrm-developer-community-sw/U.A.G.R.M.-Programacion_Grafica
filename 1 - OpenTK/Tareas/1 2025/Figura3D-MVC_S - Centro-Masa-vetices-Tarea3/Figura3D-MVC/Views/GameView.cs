using OpenTK;
using OpenTK.Graphics.OpenGL;
using crearFigruas3D.Models;
using System;
using OpenTK.Graphics;
using System.Windows.Forms; 
using System.Drawing; 

namespace crearFigruas3D.Views
{
    
    public class GameView : GameWindow
    {
        
        private GameModel _model;
        private GameDraw _gameDraw;

        private float rotationXAxes = 0.0f;  // Variable para controlar la rotación de los ejes
        private float rotationSpeed = 0.1f;  // Velocidad de la rotación (ajústalo según lo necesites)

        public GameView(GameModel model, int width, int height, string title)
            : base(width, height, GraphicsMode.Default, title)
        {
            try
            {
                
                _model = model;
                _gameDraw = new GameDraw(model);  // Instanciamos correctamente GameDraw
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
                GL.ClearColor(0.1f, 0.1f, 0.1f, 1.0f);
                GL.Enable(EnableCap.DepthTest);

                // Configurar la proyección
                GL.MatrixMode(MatrixMode.Projection);

                // Campo de visión de 45 grados, relación de aspecto de la ventana (ancho/alto)
                // Planos de corte cercano 0.1f y lejano 100f
                Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
                    MathHelper.PiOver4,  // 45 grados de campo de visión
                    Width / (float)Height,  // Relación de aspecto
                    0.1f,  // Distancia al plano cercano
                    100f   // Distancia al plano lejano
                );

                // Aplicar la matriz de proyección
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

                // Limpiar el buffer de color y profundidad
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                // Establecer la vista de la cámara
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadIdentity();

                // Mover la cámara a una distancia adecuada para ver los objetos
                GL.Translate(0.0f, 0.0f, -5.0f);  // Este valor puede ser ajustado para ver los objetos desde diferentes distancias

                // Usar la instancia de GameDraw para dibujar las figuras
                if (_gameDraw != null)
                {
                    _gameDraw.Dibujar("LetraU");
                    _gameDraw.Dibujar("Ejes");
                }
                else
                {
                    MessageBox.Show("Error: _gameDraw no ha sido inicializado.");
                }

                // Actualizar rotación de los ejes
                _gameDraw.UpdateAxesRotation();



                //============================================================================//
                // Incrementar la rotación de los ejes para la siguiente llamada
                rotationXAxes += rotationSpeed;
                if (rotationXAxes >= 360.0f) rotationXAxes -= 360.0f;  // Mantener la rotación en el rango de 0-360 grados


                // Mostrar en pantalla
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
