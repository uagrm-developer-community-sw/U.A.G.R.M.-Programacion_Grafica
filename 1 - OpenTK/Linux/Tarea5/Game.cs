using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Tarea5
{
    public class Game(int width, int height, string title) : GameWindow(width, height, GraphicsMode.Default, title) // Hereda de GameWindow para poder utilizar sus métodos y propiedades
    {
        List<IDrawable> items; // Lista de objetos a dibujar en la pantalla

        float theta = 0.0f; // Ángulo de rotación de la escena

        protected override void OnLoad(EventArgs e) // Método que se ejecuta al cargar la aplicación (una sola vez)
        {
            // Establecer el color de fondo
            GL.ClearColor(0.1f, 0.2f, 0.5f, 1.0f); // Color azul oscuro
            GL.Enable(EnableCap.DepthTest); // Habilitar el buffer de profundidad
            GL.DepthFunc(DepthFunction.Lequal); // Establecer la función de profundidad (menor o igual)
            GL.Enable(EnableCap.Blend); // Habilitar el blending (mezcla de colores)
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha); // Establecer la función de blending (fuente alfa, 1 - fuente alfa)
            items = new List<IDrawable>(); // Inicializar la lista de objetos a dibujar

        }

        protected override void OnRenderFrame(FrameEventArgs e) // Método que se ejecuta al renderizar la pantalla (cada vez que se actualiza)
        {
            GL.LoadIdentity(); // Cargar la matriz identidad
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); // Limpiar el buffer de color y el buffer de profundidad

            GL.Translate(0.0f, 0.0f, -45.0f); // Trasladar la escena en el eje Z (alejar la cámara)
            GL.Rotate(25.0f, 1.0f, 0.0f, 0.0f); // Rotar la escena 45 grados en los ejes X e Y
            GL.Rotate(theta, 0.0f, 0.5f, 0.0f); // Rotar la escena en el eje Y (según el ángulo theta)
        }
        protected override void OnResize(EventArgs e) // Método que se ejecuta al cambiar el tamaño de la ventana (cada vez que se redimensiona)
        {
            // Adjust the viewport to the new window size
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            // Add game logic, input handling
            if (Keyboard.GetState().IsKeyDown(Key.Escape))
            {
                Exit();
            }
        }

    }
}