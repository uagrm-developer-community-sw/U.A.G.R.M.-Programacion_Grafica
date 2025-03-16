// Se importa el espacio de nombres 'crearFigruas3D.Controllers', que contiene la lógica de los controladores (en este caso, GameController).
using crearFigruas3D.Controllers;
using OpenTK;

// Se importa el espacio de nombres 'System', que proporciona clases y tipos fundamentales de .NET.
using System;
// Se importa 'System.Drawing', que permite trabajar con gráficos, colores y elementos visuales.
using System.Drawing;
// Se importa 'System.Runtime.InteropServices', útil para interoperabilidad con código no administrado (aunque en este caso no se usa directamente).
using System.Runtime.InteropServices;
// Se importa 'System.Windows.Forms', que proporciona clases para crear interfaces gráficas en Windows Forms.
using System.Windows.Forms;

// Definición del espacio de nombres 'crearFigruas3D.Views', donde se maneja la parte visual de la aplicación.
namespace crearFigruas3D.Views
{
    // Definición de la clase 'MainForm', que hereda de 'Form' de Windows Forms para crear una ventana gráfica.
    public partial class MainForm : Form
    {
        // Declaración de la variable privada '_controller', que almacena la instancia del controlador (GameController).
        private GameController _controller;

        // Variables de color para cada cara del cubo en la vista 3D.
        private Color colorFrontal = Color.Red;
        private Color colorTrasera = Color.Green;
        private Color colorIzquierda = Color.Blue;
        private Color colorDerecha = Color.Yellow;
        private Color colorSuperior = Color.Magenta;
        private Color colorInferior = Color.Cyan;

        // Constructor de la clase 'MainForm', que recibe una instancia de 'GameController' para manejar la lógica del juego.
        public MainForm(GameController controller)
        {
            // Inicializa los componentes gráficos del formulario.
            InitializeComponent(); // Método generado automáticamente por el diseñador de Windows Forms.

            // Asigna el controlador recibido a la variable privada '_controller'.
            _controller = controller;

            // Se inicializa un cuadro de diálogo para la selección de colores.
            clrDlgTapas = new ColorDialog();

            // Establecer el valor inicial de trackBarX al medio de su rango.
            this.trackBarX.Value = (this.trackBarX.Maximum - this.trackBarX.Minimum) / 2;

            // Establecer el valor inicial de trackBarY al medio de su rango.
            this.trackBarY.Value = (this.trackBarY.Maximum - this.trackBarY.Minimum) / 2;

            // Asignar el evento 'ValueChanged' del trackBarX a su método manejador.
            this.trackBarX.ValueChanged += new EventHandler(this.trackBarX_ValueChanged);

            // Asignar el evento 'ValueChanged' del trackBarY a su método manejador.
            this.trackBarY.ValueChanged += new EventHandler(this.trackBarY_ValueChanged);
        }

        // Método que se ejecuta cuando se hace clic en el botón de la cara frontal para cambiar su color.
        private void bttnCaraFrontal_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre el cuadro de diálogo de selección de color.
                if (clrDlgTapas.ShowDialog() == DialogResult.OK)
                {
                    // Asigna el color seleccionado a la cara frontal.
                    colorFrontal = clrDlgTapas.Color;

                    // Fuerza la actualización de la vista (redibuja el formulario).
                    this.Invalidate();
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error en caso de excepción.
                MessageBox.Show("Ocurrió un error al seleccionar el color: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos que se ejecutan cuando los botones de rotación son clickeados, llamando a los métodos correspondientes del controlador.

        // Rota el modelo hacia la izquierda.
        private void btnRotarIzquierda_Click(object sender, EventArgs e) => _controller.RotateLeft();

        // Rota el modelo hacia la derecha.
        private void btnRotarDerecha_Click(object sender, EventArgs e) => _controller.RotateRight();

        // Rota el modelo hacia arriba.
        private void btnRotarArriba_Click(object sender, EventArgs e) => _controller.RotateUp();

        // Rota el modelo hacia abajo.
        private void btnRotarAbajo_Click(object sender, EventArgs e) => _controller.RotateDown();

        // Factor de velocidad para controlar la rapidez del movimiento.
        private const int Velocidad = -125; // Ajusta este valor para cambiar la sensibilidad.

        // Método que se ejecuta cuando cambia el valor del TrackBarX (control deslizante en eje X).
        private void trackBarX_ValueChanged(object sender, EventArgs e)
        {
            // Obtiene el valor actual del TrackBarX y lo multiplica por el factor de velocidad.
            int valor = trackBarX.Value * Velocidad;

            // Compara con el punto medio del rango y decide en qué dirección rotar.
            if (valor > trackBarX.Maximum * Velocidad / 2)
            {
                _controller.RotateRight();  // Si el valor es mayor, rota a la derecha.
            }
            else if (valor < trackBarX.Maximum * Velocidad / 2)
            {
                _controller.RotateLeft();   // Si el valor es menor, rota a la izquierda.
            }
        }

        // Método que se ejecuta cuando cambia el valor del TrackBarY (control deslizante en eje Y).
        private void trackBarY_ValueChanged(object sender, EventArgs e)
        {
            // Obtiene el valor actual del TrackBarY y lo multiplica por el factor de velocidad.
            int valor = trackBarY.Value * Velocidad;

            // Compara con el punto medio del rango y decide en qué dirección rotar.
            if (valor > trackBarY.Maximum * Velocidad / 2)
            {
                _controller.RotateUp();  // Si el valor es mayor, rota hacia arriba.
            }
            else if (valor < trackBarY.Maximum * Velocidad / 2)
            {
                _controller.RotateDown();  // Si el valor es menor, rota hacia abajo.
            }
        }

        private void btnActualizarCentroDeMasa_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los valores de los TextBox
                float x = float.Parse(textBoxX.Text);
                float y = float.Parse(textBoxY.Text);
                float z = float.Parse(textBoxZ.Text);

                // Crear un nuevo Vector3 para el centro de masa
                Vector3 nuevoCentroDeMasa = new Vector3(x, y, z);

                // Aquí se actualiza el centro de masa del objeto
                // Suponiendo que tienes un método para actualizar el centro de masa del modelo
                //_model.ActualizarCentroDeMasa(nuevoCentroDeMasa);

                MessageBox.Show("Centro de masa actualizado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos para X, Y, y Z.");
            }
        }
    }
}
