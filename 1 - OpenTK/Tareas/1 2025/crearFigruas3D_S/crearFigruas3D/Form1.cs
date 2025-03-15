using System;
using System.Windows.Forms;

namespace crearFigruas3D
{
    public partial class Form1 : Form
    {
        private static Game gameInstance; // Referencia estática a la ventana de OpenTK

        public Form1()
        {
            InitializeComponent();
        }

        public static void SetGameInstance(Game game)
        {
            gameInstance = game;
        }

        private void btnRotarIzquierda_Click(object sender, EventArgs e)
        {
            if (gameInstance != null) gameInstance.RotationY -= 5.0f;
        }

        private void btnRotarDerecha_Click(object sender, EventArgs e)
        {
            if (gameInstance != null) gameInstance.RotationY += 5.0f;
        }

        private void btnRotarArriba_Click(object sender, EventArgs e)
        {
            if (gameInstance != null) gameInstance.RotationX -= 5.0f;
        }

        private void btnRotarAbajo_Click(object sender, EventArgs e)
        {
            if (gameInstance != null) gameInstance.RotationX += 5.0f;
        }
    }
}
