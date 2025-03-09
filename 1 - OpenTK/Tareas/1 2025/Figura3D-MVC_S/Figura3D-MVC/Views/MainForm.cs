// Se importa el espacio de nombres 'crearFigruas3D.Controllers', que contiene la lógica de los controladores (en este caso, GameController).
using crearFigruas3D.Controllers;
// Se importa el espacio de nombres 'System', que proporciona clases y tipos fundamentales de .NET.
using System;
using System.Drawing;
using System.Runtime.InteropServices;


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

        private Color colorFrontal = Color.Red;
        private Color colorTrasera = Color.Green;
        private Color colorIzquierda = Color.Blue;
        private Color colorDerecha = Color.Yellow;
        private Color colorSuperior = Color.Magenta;
        private Color colorInferior = Color.Cyan;



        // Constructor de la clase 'MainForm', que recibe una instancia de 'GameController' y la asigna a la variable '_controller'.
        public MainForm(GameController controller)
        {
            // Llama al método 'InitializeComponent()', que inicializa los componentes del formulario, como botones y controles.
            // Este método es generado automáticamente por el diseñador de Windows Forms.
            InitializeComponent(); // Solo llama al método, no lo redefine

            // Asigna el controlador recibido al campo '_controller' para que pueda interactuar con la lógica del juego.
            _controller = controller;

        


            clrDlgTapas = new ColorDialog();
            
           


            // Establecer el valor inicial de trackBarX al medio de su rango (esto es ahora en MainForm.cs, no en el diseñador)
            this.trackBarX.Value = (this.trackBarX.Maximum - this.trackBarX.Minimum) / 2;

            // Establecer el valor inicial de trackBarY al medio de su rango (esto también en MainForm.cs)
            this.trackBarY.Value = (this.trackBarY.Maximum - this.trackBarY.Minimum) / 2;

            // Asignar el evento ValueChanged del trackBarX a su manejador
            this.trackBarX.ValueChanged += new EventHandler(this.trackBarX_ValueChanged);

            this.trackBarY.ValueChanged += new EventHandler(this.trackBarY_ValueChanged);
        }

        private void bttnCaraFrontal_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Abre el diálogo de color
                if (clrDlgTapas.ShowDialog() == DialogResult.OK)
                {

                    // Cambia el color de la cara frontal
                    colorFrontal = clrDlgTapas.Color;

                    // Forzamos la actualización de la vista
                    this.Invalidate();  // Esto redibuja el formulario (o la parte específica del formulario)
                }
            }
            catch (Exception ex)
            {
                // Si ocurre alguna excepción, se captura y se muestra un mensaje
                MessageBox.Show("Ocurrió un error al seleccionar el color: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void bttnCaraTrasera_Click(object sender, EventArgs e)
        {
            SeleccionarColor(2);
        }

        private void bttnCaraIzquierda_Click(object sender, EventArgs e)
        {
            SeleccionarColor(3);
        }

        private void bttnCaraDerecha_Click(object sender, EventArgs e)
        {
            SeleccionarColor(4);
        }

        private void bttnCaraSuperior_Click(object sender, EventArgs e)
        {
            SeleccionarColor(5);
        }

        private void bttnCaraInferior_Click(object sender, EventArgs e)
        {
            SeleccionarColor(6);
        }

        private void SeleccionarColor(int tapa)
        {
            if (clrDlgTapas.ShowDialog() == DialogResult.OK)
            {
                Color colorSeleccionado = clrDlgTapas.Color;
                switch (tapa)
                {
                    case 1:
                        colorFrontal = colorSeleccionado;
                        break;
                    case 2:
                        colorTrasera = colorSeleccionado;
                        break;
                    case 3:
                        colorIzquierda = colorSeleccionado;
                        break;
                    case 4:
                        colorDerecha = colorSeleccionado;
                        break;
                    case 5:
                        colorSuperior = colorSeleccionado;
                        break;
                    case 6:
                        colorInferior = colorSeleccionado;
                        break;
                }

                // Llamar al método del controlador para actualizar los colores en la vista
                _controller.ActualizarColores(colorFrontal, colorTrasera, colorIzquierda,
                                              colorDerecha, colorSuperior, colorInferior);
            }
        }


        // Método que se ejecuta cuando el botón 'btnRotarIzquierda' es clickeado. Llama al método 'RotateLeft()' del controlador para rotar el modelo hacia la izquierda.
        private void btnRotarIzquierda_Click(object sender, EventArgs e) => _controller.RotateLeft();

        // Método que se ejecuta cuando el botón 'btnRotarDerecha' es clickeado. Llama al método 'RotateRight()' del controlador para rotar el modelo hacia la derecha.
        private void btnRotarDerecha_Click(object sender, EventArgs e) => _controller.RotateRight();

        // Método que se ejecuta cuando el botón 'btnRotarArriba' es clickeado. Llama al método 'RotateUp()' del controlador para rotar el modelo hacia arriba.
        private void btnRotarArriba_Click(object sender, EventArgs e) => _controller.RotateUp();

        // Método que se ejecuta cuando el botón 'btnRotarAbajo' es clickeado. Llama al método 'RotateDown()' del controlador para rotar el modelo hacia abajo.
        private void btnRotarAbajo_Click(object sender, EventArgs e) => _controller.RotateDown();

        // Factor de velocidad para controlar la rapidez del movimiento
        private const int Velocidad = -125; // Puedes ajustar este valor para aumentar o disminuir la velocidad

        // Método para manejar el evento ValueChanged del TrackBarX
        private void trackBarX_ValueChanged(object sender, EventArgs e)
        {
            // Obtener el valor del TrackBarX y multiplicarlo por el factor de velocidad
            int valor = trackBarX.Value * Velocidad;

            // Verificar si el valor del TrackBarX es mayor que el valor inicial (supuesto valor medio)
            if (valor > trackBarX.Maximum * Velocidad / 2)
            {
                _controller.RotateRight();  // Si el valor es mayor, rotar a la derecha
            }
            else if (valor < trackBarX.Maximum * Velocidad / 2)
            {
                _controller.RotateLeft();   // Si el valor es menor, rotar a la izquierda
            }
        }

        // Método para manejar el evento ValueChanged del TrackBarY
        private void trackBarY_ValueChanged(object sender, EventArgs e)
        {
            // Obtener el valor del TrackBarY y multiplicarlo por el factor de velocidad
            int valor = trackBarY.Value * Velocidad;

            // Verificar si el valor del TrackBarY es mayor que el valor inicial (supuesto valor medio)
            if (valor > trackBarY.Maximum * Velocidad / 2)
            {
                _controller.RotateUp();  // Si el valor es mayor, rotar hacia arriba
            }
            else if (valor < trackBarY.Maximum * Velocidad / 2)
            {
                _controller.RotateDown();  // Si el valor es menor, rotar hacia abajo
            }
        }


    }
}
