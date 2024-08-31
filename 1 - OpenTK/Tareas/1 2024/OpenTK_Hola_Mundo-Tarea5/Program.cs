using System;
using System.Windows.Forms;

namespace OpenTK_Hola_Mundo
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // This line creates a new instance, and wraps the instance in a using statement so it's automatically disposed once we've exited the block.
            using (Game game = new Game(800, 600, "OpenTK - Hola Mundo"))
            {
                Form formulario = new Form();
                formulario.Text = "Formulario de Ejemplo";
                formulario.Size = new System.Drawing.Size(300, 200);

                // Creamos algunos controles en el formulario (por ejemplo, un botón)
                Button boton = new Button();
                boton.Text = "Haz clic";
                boton.Location = new System.Drawing.Point(50, 50);
                formulario.Controls.Add(boton);

                // Asociamos un evento al botón
                boton.Click += (sender, e) => {
                    MessageBox.Show("¡Haz hecho clic en el botón!");
                };

                // Mostramos ambos formularios
                formulario.Show();

                //Run takes a double, which is how many frames per second it should strive to reach.
                //You can leave that out and it'll just update as fast as the hardware will allow it.
                game.Run(60.0);
            }
        }
    }
}
