using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args) // Punto de entrada del programa
        {
            using (Game game = new Game(800, 600, "Letra T")) // Ventana de 800x600 con título "Letra T"
            {
                //--------------------------------
                // Crear un formulario para mostrar
                Form formulario = new Form();

                //--------------------------------
                // Configurar el formulario
                formulario.Text = "Letra T";
                formulario.Width = 800;
                formulario.Height = 600;
                formulario.FormBorderStyle = FormBorderStyle.FixedDialog;
                formulario.MaximizeBox = false; // Cambiado a false para evitar maximizar
                formulario.MinimizeBox = true;
                formulario.StartPosition = FormStartPosition.CenterScreen;

                //--------------------------------
                // Configurar el evento de cierre
                formulario.FormClosed += (sender, e) => game.Exit();

                //--------------------------------
                // Configurar el evento de teclado
                formulario.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.Escape) // Si se presiona la tecla escape
                    {
                        game.Exit(); // Cierra el programa
                    }
                };

                //--------------------------------
                // Configurar el evento de redimensionar
                formulario.Resize += (sender, e) =>
                {
                    game.Width = formulario.Width; // Cambiar el ancho de la ventana
                    game.Height = formulario.Height; // Cambiar el alto de la ventana
                    GL.Viewport(0, 0, game.Width, game.Height); // Establecer el viewport de la ventana con el nuevo tamaño
                };

                //--------------------------------
                // Crear un botón para mostrar la letra T
                Button botonMostrar = new Button();
                botonMostrar.Text = "Mostrar Letra T";
                botonMostrar.Width = 150;
                botonMostrar.Height = 30;
                botonMostrar.Location = new System.Drawing.Point(50, 50);
                formulario.Controls.Add(botonMostrar);
                botonMostrar.Click += (sender, e) =>
                {
                    game.Run(60.0); // Correr a 60 FPS
                };

                //--------------------------------
                // Mostrar el formulario
                formulario.Show(); // Mostrar el formulario
                //--------------------------------
                // Inicializar el programa aquí
                // game.Run(60.0); // Esta línea se elimina para evitar que el juego se ejecute inmediatamente
                Application.Run(formulario); // Se añade para mantener el formulario abierto y manejar correctamente los eventos
            }
        }
    }
}