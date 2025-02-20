using System;
using System.Threading;
using System.Windows.Forms;
using crearFigruas3D.Controllers;  // Se importa el espacio de nombres para los controladores
using crearFigruas3D.Views;        // Se importa el espacio de nombres para las vistas

namespace crearFigruas3D
{
    static class Program
    {
        [STAThread]  // Atributo que indica que el hilo principal es de un solo hilo (STA) para que funcione correctamente con la interfaz gráfica.
        static void Main()
        {
            // Habilitar estilos visuales en la aplicación para que se utilicen las opciones de apariencia modernas.
            Application.EnableVisualStyles();
            // Configura si el renderizado de texto será compatible con la forma predeterminada de los formularios.
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear una instancia del controlador que manejará la lógica de la aplicación.
            GameController controller = new GameController();

            // Crear un hilo para ejecutar la interfaz gráfica de usuario (UI) de Windows Forms
            Thread uiThread = new Thread(() =>
            {
                // Ejecutar el formulario principal de la aplicación en el hilo de la UI
                // El formulario 'MainForm' recibe como parámetro el controlador 'controller'.
                Application.Run(new MainForm(controller));
            });

            // Establecer el estado del hilo como STA (Single-Threaded Apartment), necesario para la ejecución de la interfaz gráfica.
            uiThread.SetApartmentState(ApartmentState.STA);
            // Iniciar el hilo de la interfaz gráfica de usuario.
            uiThread.Start();

            // Ejecutar OpenTK (que podría estar manejando la lógica 3D) en el hilo principal.
            // Esto permite que la parte gráfica y la lógica del juego se ejecuten de manera separada y sin bloquear la interfaz de usuario.
            controller.Run();
        }
    }
}
