// Se importa el espacio de nombres 'crearFigruas3D.Controllers', que contiene la lógica de los controladores (en este caso, GameController).
using crearFigruas3D.Controllers;
// Se importa el espacio de nombres 'System', que proporciona clases y tipos fundamentales de .NET.
using System;
// Se importa el espacio de nombres 'System.Windows.Forms', que contiene las clases necesarias para crear aplicaciones con formularios en Windows.
using System.Windows.Forms;

// Definición del espacio de nombres 'crearFigruas3D.Views', donde se maneja la parte visual de la aplicación.
namespace crearFigruas3D.Views
{
    // Definición de la clase 'MainForm', que hereda de la clase 'Form' de Windows Forms para crear una ventana de la interfaz gráfica.
    public partial class MainForm : Form
    {
        // Declaración de la variable privada '_controller', que almacenará la instancia del controlador (GameController).
        private GameController _controller;

        // Constructor de la clase 'MainForm', que recibe una instancia de 'GameController' y la asigna a la variable '_controller'.
        public MainForm(GameController controller)
        {
            // Llama al método 'InitializeComponent()', que inicializa los componentes del formulario, como botones y controles.
            // Este método es generado automáticamente por el diseñador de Windows Forms.
            InitializeComponent(); // Solo llama al método, no lo redefine

            // Asigna el controlador recibido al campo '_controller' para que pueda interactuar con la lógica del juego.
            _controller = controller;
        }

        // Método que se ejecuta cuando el botón 'btnRotarIzquierda' es clickeado. Llama al método 'RotateLeft()' del controlador para rotar el modelo hacia la izquierda.
        private void btnRotarIzquierda_Click(object sender, EventArgs e) => _controller.RotateLeft();

        // Método que se ejecuta cuando el botón 'btnRotarDerecha' es clickeado. Llama al método 'RotateRight()' del controlador para rotar el modelo hacia la derecha.
        private void btnRotarDerecha_Click(object sender, EventArgs e) => _controller.RotateRight();

        // Método que se ejecuta cuando el botón 'btnRotarArriba' es clickeado. Llama al método 'RotateUp()' del controlador para rotar el modelo hacia arriba.
        private void btnRotarArriba_Click(object sender, EventArgs e) => _controller.RotateUp();

        // Método que se ejecuta cuando el botón 'btnRotarAbajo' es clickeado. Llama al método 'RotateDown()' del controlador para rotar el modelo hacia abajo.
        private void btnRotarAbajo_Click(object sender, EventArgs e) => _controller.RotateDown();
    }
}
