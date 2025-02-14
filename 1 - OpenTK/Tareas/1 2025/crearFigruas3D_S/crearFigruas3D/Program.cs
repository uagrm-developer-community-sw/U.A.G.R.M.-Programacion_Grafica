using System; // Importa el espacio de nombres System para acceder a funcionalidades básicas como hilo, excepciones, etc.
using System.Threading; // Importa el espacio de nombres que permite trabajar con hilos (threads).
using System.Windows.Forms; // Importa el espacio de nombres de Windows Forms, necesario para la interfaz gráfica.

namespace crearFigruas3D // Define el espacio de nombres para organizar el código.
{
    static class Program // La clase Program es estática y contiene el punto de entrada de la aplicación.
    {
        private static Game game; // Declara una referencia estática para el objeto 'game' de la clase Game.

        [STAThread] // Especifica que la aplicación debe usar un solo hilo de interfaz de usuario (hilo principal de la UI).
        static void Main() // El punto de entrada de la aplicación, el primer método que se ejecuta al iniciar.
        {
            // Iniciar el juego en un hilo separado
            Thread gameThread = new Thread(() => // Crea un nuevo hilo para ejecutar el juego sin bloquear la UI.
            {
                using (game = new Game(800, 600, "Figura 3D")) // Crea una nueva instancia del juego con una ventana de 800x600 píxeles.
                {
                    Form1.SetGameInstance(game); // Pasa la referencia del juego a Form1 para interactuar con él desde el formulario.
                    game.Run(60.0); // Inicia el juego con una tasa de actualización de 60 cuadros por segundo.
                }
            });

            gameThread.IsBackground = true; // Hace que el hilo sea un hilo de fondo, es decir, se cerrará automáticamente cuando la aplicación termine.
            gameThread.Start(); // Inicia el hilo del juego.

            // Iniciar el formulario en el hilo principal de Windows Forms
            Application.EnableVisualStyles(); // Habilita los estilos visuales del sistema operativo para la interfaz de usuario.
            Application.SetCompatibleTextRenderingDefault(false); // Establece si se debe usar el motor de renderizado de texto predeterminado.
            Application.Run(new Form1()); // Inicia el formulario en el hilo principal de la aplicación (UI), permitiendo que el formulario se muestre y sea interactivo.
        }
    }
}
