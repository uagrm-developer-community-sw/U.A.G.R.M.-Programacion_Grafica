using crearFigruas3D.Controllers;
using System;
using System.Windows.Forms;

namespace crearFigruas3D.Views
{
    public partial class MainForm : Form
    {
        private GameController _controller;

        public MainForm(GameController controller)
        {
            InitializeComponent(); // Solo llama al método, no lo redefine
            _controller = controller;
        }

        private void btnRotarIzquierda_Click(object sender, EventArgs e) => _controller.RotateLeft();
        private void btnRotarDerecha_Click(object sender, EventArgs e) => _controller.RotateRight();
        private void btnRotarArriba_Click(object sender, EventArgs e) => _controller.RotateUp();
        private void btnRotarAbajo_Click(object sender, EventArgs e) => _controller.RotateDown();
    }
}
