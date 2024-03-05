using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace opentk
{
    public class Game
    {
        GameWindow window; // Ventana del juego
        public Game( GameWindow window) // Constructor
        {
            this.window = window; // Asigna la ventana
            Start(); // Inicia el juego

        }

        void Start() // Inicia el juego
        {
            window.Load += loaded; // Asigna el evento de carga
            window.RenderFrame += render; // Asigna el evento de renderizado
            window.Run(1.0/60.0); // Ejecute la ventana a 60 fps
        }

        void render(object o, FrameEventArgs e) // Evento de renderizado
        {
            GL.Clear(ClearBufferMask.ColorBufferBit); // Limpia el buffer de color
            window.SwapBuffers(); // Intercambia los buffers
        }

        void loaded(object o, EventArgs e) // Evento de carga
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f); // Establece el color de fondo
        }

    }
}
