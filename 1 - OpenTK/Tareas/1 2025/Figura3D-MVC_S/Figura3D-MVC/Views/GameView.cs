// Se importa el espacio de nombres 'OpenTK', que proporciona funcionalidad básica para trabajar con gráficos 3D usando OpenGL.
using OpenTK;
// Se importa el espacio de nombres 'OpenTK.Graphics.OpenGL', que contiene las funciones necesarias para interactuar con OpenGL.
using OpenTK.Graphics.OpenGL;
// Se importa el espacio de nombres 'crearFigruas3D.Models', que contiene la lógica y los datos del modelo (como las rotaciones).
using crearFigruas3D.Models;
// Se importa el espacio de nombres 'System', que contiene las clases y tipos básicos de .NET.
using System;
// Se importa el espacio de nombres 'OpenTK.Graphics', que permite configurar aspectos gráficos como el modo de visualización.
using OpenTK.Graphics;
using System.Windows.Forms;

// Definición del espacio de nombres 'crearFigruas3D.Views', donde se maneja la parte visual de la aplicación.
namespace crearFigruas3D.Views
{
    // Definición de la clase 'GameView', que hereda de 'GameWindow', una clase de OpenTK para crear una ventana de gráficos 3D.
    public class GameView : GameWindow
    {
        // Declaración de la variable privada '_model', que almacenará el modelo de datos que contiene las rotaciones.
        private GameModel _model;

        // Constructor de la clase 'GameView', que recibe el modelo, el ancho, el alto y el título de la ventana.
        public GameView(GameModel model, int width, int height, string title)
            : base(width, height, GraphicsMode.Default, title)
        {
            try
            {
                // Se asigna el modelo recibido al campo privado '_model'.
                _model = model;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la vista: " + ex.Message);
            }
        }

        // Método que se ejecuta cuando la ventana se carga inicialmente. Es un evento de OpenTK.
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                // Llama al método base (de la clase GameWindow) para que se ejecute la funcionalidad predeterminada.
                base.OnLoad(e);
                // Establece el color de fondo de la pantalla, en este caso un gris oscuro (0.1f en R, G, B y 1.0f en A para la transparencia).
                GL.ClearColor(0.1f, 0.1f, 0.1f, 1.0f);
                // Habilita el test de profundidad, necesario para que los objetos cercanos a la cámara se dibujen sobre los objetos lejanos.
                GL.Enable(EnableCap.DepthTest);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ventana: " + ex.Message);
            }
        }

        // Método que se ejecuta para renderizar cada fotograma. Es otro evento de OpenTK.
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            try
            {
                // Llama al método base (de la clase GameWindow) para que se ejecute la funcionalidad predeterminada.
                base.OnRenderFrame(e);
                // Limpia el buffer de color y de profundidad antes de dibujar el nuevo fotograma.
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                // Establece que las operaciones de matrices afectarán la "matriz de modelo" (la transformación de objetos).
                GL.MatrixMode(MatrixMode.Modelview);
                // Resetea la matriz de modelo (limpia las transformaciones previas).
                GL.LoadIdentity();
                // Desplaza la escena para alejarla de la cámara (en este caso, 3 unidades en el eje Z).
                GL.Translate(0.0f, 0.0f, -3.0f);
                // Rota la escena en el eje X, usando el valor de rotación del modelo.
                GL.Rotate(_model.RotationX, 1.0f, 0.0f, 0.0f);
                // Rota la escena en el eje Y, usando el valor de rotación del modelo.
                GL.Rotate(_model.RotationY, 0.0f, 1.0f, 0.0f);

                // Comienza a dibujar una figura utilizando el tipo de primitivas 'Quads' (cuadriláteros).
                GL.Begin(PrimitiveType.Quads);

                // Dibuja las caras del cubo, cada una con un color diferente.

                // Cara frontal (roja)
                GL.Color3(1.0f, 0.0f, 0.0f);
                GL.Vertex3(-0.5f, -0.5f, 0.5f);  // Esquina inferior izquierda
                GL.Vertex3(0.5f, -0.5f, 0.5f);   // Esquina inferior derecha
                GL.Vertex3(0.5f, 0.5f, 0.5f);    // Esquina superior derecha
                GL.Vertex3(-0.5f, 0.5f, 0.5f);   // Esquina superior izquierda

                // Cara trasera (verde)
                GL.Color3(0.0f, 1.0f, 0.0f);
                GL.Vertex3(-0.5f, -0.5f, -0.5f);
                GL.Vertex3(0.5f, -0.5f, -0.5f);
                GL.Vertex3(0.5f, 0.5f, -0.5f);
                GL.Vertex3(-0.5f, 0.5f, -0.5f);

                // Cara izquierda (azul)
                GL.Color3(0.0f, 0.0f, 1.0f);
                GL.Vertex3(-0.5f, -0.5f, -0.5f);
                GL.Vertex3(-0.5f, -0.5f, 0.5f);
                GL.Vertex3(-0.5f, 0.5f, 0.5f);
                GL.Vertex3(-0.5f, 0.5f, -0.5f);

                // Cara derecha (amarilla)
                GL.Color3(1.0f, 1.0f, 0.0f);
                GL.Vertex3(0.5f, -0.5f, -0.5f);
                GL.Vertex3(0.5f, -0.5f, 0.5f);
                GL.Vertex3(0.5f, 0.5f, 0.5f);
                GL.Vertex3(0.5f, 0.5f, -0.5f);

                // Cara superior (magenta)
                GL.Color3(1.0f, 0.0f, 1.0f);
                GL.Vertex3(-0.5f, 0.5f, -0.5f);
                GL.Vertex3(0.5f, 0.5f, -0.5f);
                GL.Vertex3(0.5f, 0.5f, 0.5f);
                GL.Vertex3(-0.5f, 0.5f, 0.5f);

                // Cara inferior (cian)
                GL.Color3(0.0f, 1.0f, 1.0f);
                GL.Vertex3(-0.5f, -0.5f, -0.5f);
                GL.Vertex3(0.5f, -0.5f, -0.5f);
                GL.Vertex3(0.5f, -0.5f, 0.5f);
                GL.Vertex3(-0.5f, -0.5f, 0.5f);

                // Finaliza el dibujo de las primitivas.
                GL.End();

                // Intercambia los buffers para mostrar lo que se ha dibujado en el frame actual (renderizado de doble buffer).
                SwapBuffers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al renderizar el fotograma: " + ex.Message);
            }
        }

        // Método que se ejecuta cuando la ventana se redimensiona. Se actualiza el viewport y la matriz de proyección.
        protected override void OnResize(EventArgs e)
        {
            try
            {
                // Llama al método base (de la clase GameWindow) para que se ejecute la funcionalidad predeterminada.
                base.OnResize(e);
                // Actualiza el área de visualización del OpenGL para que cubra toda la ventana.
                GL.Viewport(0, 0, Width, Height);

                // Crea una nueva matriz de proyección perspectiva usando una relación de aspecto basada en el tamaño actual de la ventana.
                Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 0.1f, 100f);
                // Cambia la matriz actual a la de proyección (definir cómo se proyectan los objetos en la ventana).
                GL.MatrixMode(MatrixMode.Projection);
                // Carga la matriz de proyección calculada en OpenGL.
                GL.LoadMatrix(ref projection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al redimensionar la ventana: " + ex.Message);
            }
        }
    }
}
