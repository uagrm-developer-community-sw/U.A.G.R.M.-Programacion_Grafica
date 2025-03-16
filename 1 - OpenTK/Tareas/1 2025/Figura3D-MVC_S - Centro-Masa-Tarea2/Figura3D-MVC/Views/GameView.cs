
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

        private float rotationXAxes = 0.0f;  // Variable para controlar la rotación de los ejes
        private float rotationSpeed = 0.1f;  // Velocidad de la rotación (ajústalo según lo necesites)



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
                //                                ULETTERMODEL
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

                //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                // tAREA 2 : Dibujar la letra "U" en otra posición


                // Coordenadas para las nuevas posiciones
                float x1 = -2.0f, y1 = -1.0f, z1 = -7.0f;   // Primera posición
                float x2 = -2.0f, y2 = -2.0f, z2 = -4.0f; // Segunda posición

                // Duplicar el objeto en la primera posición
                GL.PushMatrix();  // Guardar la matriz actual
                GL.Translate(x1, y1, z1);  // Traslación a la primera posición
                ULetterModel.DrawU();  // Dibujar la letra "U" en la primera posición
                GL.PopMatrix();  // Restaurar la matriz

                // Duplicar el objeto en la segunda posición
                GL.PushMatrix();  // Guardar la matriz actual
                GL.Translate(x2, y2, z2);  // Traslación a la segunda posición
                ULetterModel.DrawU();  // Dibujar la letra "U" en la segunda posición
                GL.PopMatrix();  // Restaurar la matriz


                //============================================================================//
                //                                AXESMODEL

                // Calcular el centro de masa de los ejes
                Vector3 centerOfMassAxes = AxesModel.CalculateCenterOfMass();
                Console.WriteLine("Centro de masa de los ejes: " + centerOfMassAxes);

                // Traslación para mover los ejes a su propio centro de masa
                GL.PushMatrix();  // Guardar la matriz actual
                GL.Translate(-centerOfMassAxes.X, -centerOfMassAxes.Y, -centerOfMassAxes.Z);  // Mover al centro de masa de los ejes
                GL.Rotate(rotationXAxes, 0.0f, 1.0f, 0.0f);  // Rotar sobre el eje y

                // Dibujar los ejes en su propio centro de masa
                AxesModel.DrawAxes();

                GL.PopMatrix();  // Restaurar la matriz para no afectar otros objetos

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
