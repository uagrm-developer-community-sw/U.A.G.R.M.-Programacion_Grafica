
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

                //============================================================================//
                // Calcular el centro de masa de la letra "U"
                Vector3 centerOfMassU = ULetterModel.CalculateCenterOfMass();
                Console.WriteLine("Centro de masa de la letra U: " + centerOfMassU);

                // Traslación para mover la letra "U" a su centro de masa
                GL.PushMatrix();  // Guardar la matriz actual
                GL.Translate(centerOfMassU.X + 1.0f, centerOfMassU.Y + 1.0f, centerOfMassU.Z + 1.0f);  // Agrega desplazamiento positivo

                // Aplicar rotaciones y movimientos basados en las variables del modelo
                GL.Rotate(_model.RotationX, 1.0f, 0.0f, 0.0f);
                GL.Rotate(_model.RotationY, 0.0f, 1.0f, 0.0f);

                // Dibujar la letra U en su propio centro de masa
                ULetterModel.DrawU();

                GL.PopMatrix();  // Restaurar la matriz para no afectar el siguiente objeto

                //============================================================================//

                // Calcular el centro de masa de los ejes
                Vector3 centerOfMassAxes = AxesModel.CalculateCenterOfMass();
                Console.WriteLine("Centro de masa de los ejes: " + centerOfMassAxes);

                // Traslación para mover los ejes a su propio centro de masa
                GL.PushMatrix();  // Guardar la matriz actual
                GL.Translate(centerOfMassAxes.X, centerOfMassAxes.Y, centerOfMassAxes.Z);  // Deja los ejes en el origen

                // Dibujar los ejes en su propio centro de masa
                AxesModel.DrawAxes();

                GL.PopMatrix();  // Restaurar la matriz para no afectar otros objetos

                //============================================================================//

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
