// Program.cs

using System;
using System.Threading;
using System.Windows.Forms;
using crearFigruas3D.Controllers;
using crearFigruas3D.Views;

namespace crearFigruas3D
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Crear el controlador
                GameController controller = new GameController();

                // Cargar los objetos JSON desde el controlador
                controller.CargarObjetoJson();  // Llama aquí para cargar el JSON

                // Crear e iniciar la interfaz gráfica
                Thread uiThread = new Thread(() =>
                {
                    Application.Run(new MainForm(controller));
                });

                uiThread.SetApartmentState(ApartmentState.STA);
                uiThread.Start();

                // Iniciar la lógica del juego
                controller.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar la aplicación: " + ex.Message);
            }
        }
    }
}
