
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

        
        private Color colorFrontal = Color.Red;
        private Color colorTrasera = Color.Green;
        private Color colorIzquierda = Color.Blue;
        private Color colorDerecha = Color.Yellow;
        private Color colorSuperior = Color.Magenta;
        private Color colorInferior = Color.Cyan;

        
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

                
                GL.Translate(0.0f, 0.0f, -4.0f);

                
                GL.Rotate(_model.RotationX, 1.0f, 0.0f, 0.0f);
                GL.Rotate(_model.RotationY, 0.0f, 1.0f, 0.0f);

                
                GL.Begin(PrimitiveType.Quads);

                

                
                GL.Color3(1.0f, 0.0f, 0.0f); 
                GL.Vertex3(-0.5f, -0.5f, 0.2f);
                GL.Vertex3(-0.3f, -0.5f, 0.2f);
                GL.Vertex3(-0.3f, 0.5f, 0.2f);
                GL.Vertex3(-0.5f, 0.5f, 0.2f);

                
                GL.Color3(0.0f, 1.0f, 0.0f); 
                GL.Vertex3(0.3f, -0.5f, 0.2f);
                GL.Vertex3(0.5f, -0.5f, 0.2f);
                GL.Vertex3(0.5f, 0.5f, 0.2f);
                GL.Vertex3(0.3f, 0.5f, 0.2f);

                
                GL.Color3(0.0f, 0.0f, 1.0f); 
                GL.Vertex3(-0.3f, -0.5f, 0.2f);
                GL.Vertex3(0.3f, -0.5f, 0.2f);
                GL.Vertex3(0.3f, -0.3f, 0.2f);
                GL.Vertex3(-0.3f, -0.3f, 0.2f);

                
                GL.Color3(0.7f, 0.3f, 0.1f);  
                GL.Vertex3(-0.5f, 0.5f, 0.2f);
                GL.Vertex3(-0.5f, 0.5f, -0.2f);
                GL.Vertex3(-0.5f, -0.5f, -0.2f);
                GL.Vertex3(-0.5f, -0.5f, 0.2f);

                
                GL.Color3(1.0f, 0.5f, 0.0f);  
                GL.Vertex3(-0.5f, -0.5f, -0.2f);
                GL.Vertex3(-0.3f, -0.5f, -0.2f);
                GL.Vertex3(-0.3f, 0.5f, -0.2f);
                GL.Vertex3(-0.5f, 0.5f, -0.2f);

                GL.Color3(0.5f, 0.0f, 1.0f);  
                GL.Vertex3(0.3f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, 0.5f, -0.2f);
                GL.Vertex3(0.3f, 0.5f, -0.2f);

                
                GL.Color3(1.0f, 0.8f, 0.0f);  
                GL.Vertex3(-0.3f, -0.5f, -0.2f);
                GL.Vertex3(0.3f, -0.5f, -0.2f);
                GL.Vertex3(0.3f, -0.3f, -0.2f);
                GL.Vertex3(-0.3f, -0.3f, -0.2f);

                
                GL.Color3(0.4f, 0.4f, 0.4f);  
                GL.Vertex3(-0.5f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, 0.2f);
                GL.Vertex3(-0.5f, -0.5f, 0.2f);

                
                GL.Color3(0.2f, 0.5f, 0.8f);  
                GL.Vertex3(0.5f, 0.5f, 0.2f);
                GL.Vertex3(0.5f, 0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, -0.2f);
                GL.Vertex3(0.5f, -0.5f, 0.2f);

                
                GL.Color3(0.9f, 0.3f, 0.6f);  
                GL.Vertex3(-0.5f, 0.5f, 0.2f);
                GL.Vertex3(-0.3f, 0.5f, 0.2f);
                GL.Vertex3(-0.3f, 0.5f, -0.2f);
                GL.Vertex3(-0.5f, 0.5f, -0.2f);

                
                GL.Color3(0.1f, 0.7f, 0.4f);  
                GL.Vertex3(0.3f, 0.5f, 0.2f);
                GL.Vertex3(0.5f, 0.5f, 0.2f);
                GL.Vertex3(0.5f, 0.5f, -0.2f);
                GL.Vertex3(0.3f, 0.5f, -0.2f);

                
                GL.Color3(0.6f, 0.2f, 0.9f);  
                GL.Vertex3(-0.3f, 0.5f, 0.2f);
                GL.Vertex3(-0.3f, 0.5f, -0.2f);
                GL.Vertex3(-0.3f, -0.5f, -0.2f);
                GL.Vertex3(-0.3f, -0.5f, 0.2f);

                
                GL.Color3(1.0f, 0.7f, 0.0f);  
                GL.Vertex3(0.3f, 0.5f, 0.2f);  
                GL.Vertex3(0.3f, 0.5f, -0.2f); 
                GL.Vertex3(0.3f, -0.5f, -0.2f); 
                GL.Vertex3(0.3f, -0.5f, 0.2f);  

                
                GL.Color3(0.9f, 0.9f, 0.9f);  

                GL.Vertex3(-0.3f, -0.30f, 0.2f);  
                GL.Vertex3(0.3f, -0.30f, 0.2f);   
                GL.Vertex3(0.3f, -0.30f, -0.2f);  
                GL.Vertex3(-0.3f, -0.30f, -0.2f); 

                GL.End(); 

                
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
