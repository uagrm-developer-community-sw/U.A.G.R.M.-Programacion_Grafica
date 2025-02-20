namespace crearFigruas3D.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnRotarIzquierda;
        private System.Windows.Forms.Button btnRotarDerecha;
        private System.Windows.Forms.Button btnRotarArriba;
        private System.Windows.Forms.Button btnRotarAbajo;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #endregion

        private void InitializeComponent()
        {
            this.btnRotarIzquierda = new System.Windows.Forms.Button();
            this.btnRotarDerecha = new System.Windows.Forms.Button();
            this.btnRotarArriba = new System.Windows.Forms.Button();
            this.btnRotarAbajo = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Configuración de los botones
            this.btnRotarIzquierda.Text = "← Izquierda";
            this.btnRotarIzquierda.Location = new System.Drawing.Point(20, 50);
            this.btnRotarIzquierda.Size = new System.Drawing.Size(120, 30);
            this.btnRotarIzquierda.Click += new System.EventHandler(this.btnRotarIzquierda_Click);

            this.btnRotarDerecha.Text = "→ Derecha";
            this.btnRotarDerecha.Location = new System.Drawing.Point(150, 50);
            this.btnRotarDerecha.Size = new System.Drawing.Size(120, 30);
            this.btnRotarDerecha.Click += new System.EventHandler(this.btnRotarDerecha_Click);

            this.btnRotarArriba.Text = "↑ Arriba";
            this.btnRotarArriba.Location = new System.Drawing.Point(90, 10);
            this.btnRotarArriba.Size = new System.Drawing.Size(120, 30);
            this.btnRotarArriba.Click += new System.EventHandler(this.btnRotarArriba_Click);

            this.btnRotarAbajo.Text = "↓ Abajo";
            this.btnRotarAbajo.Location = new System.Drawing.Point(90, 90);
            this.btnRotarAbajo.Size = new System.Drawing.Size(120, 30);
            this.btnRotarAbajo.Click += new System.EventHandler(this.btnRotarAbajo_Click);

            // Establecer alineación de texto
            this.btnRotarIzquierda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRotarDerecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRotarArriba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRotarAbajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Agregar controles al formulario
            this.Controls.Add(this.btnRotarIzquierda);
            this.Controls.Add(this.btnRotarDerecha);
            this.Controls.Add(this.btnRotarArriba);
            this.Controls.Add(this.btnRotarAbajo);

            this.ResumeLayout(false);
        }
    }
}
