namespace crearFigruas3D
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.btnRotarIzquierda = new System.Windows.Forms.Button();
            this.btnRotarDerecha = new System.Windows.Forms.Button();
            this.btnRotarArriba = new System.Windows.Forms.Button();
            this.btnRotarAbajo = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 150);
            this.Name = "Form1";
            this.Text = "Control de Rotación";

            // Botón Rotar Izquierda
            this.btnRotarIzquierda.Location = new System.Drawing.Point(30, 50);
            this.btnRotarIzquierda.Name = "btnRotarIzquierda";
            this.btnRotarIzquierda.Size = new System.Drawing.Size(100, 30);
            this.btnRotarIzquierda.Text = "← Izquierda";
            this.btnRotarIzquierda.UseVisualStyleBackColor = true;
            this.btnRotarIzquierda.Click += new System.EventHandler(this.btnRotarIzquierda_Click);

            // Botón Rotar Derecha
            this.btnRotarDerecha.Location = new System.Drawing.Point(150, 50);
            this.btnRotarDerecha.Name = "btnRotarDerecha";
            this.btnRotarDerecha.Size = new System.Drawing.Size(100, 30);
            this.btnRotarDerecha.Text = "→ Derecha";
            this.btnRotarDerecha.UseVisualStyleBackColor = true;
            this.btnRotarDerecha.Click += new System.EventHandler(this.btnRotarDerecha_Click);

            // Botón Rotar Arriba
            this.btnRotarArriba.Location = new System.Drawing.Point(90, 10);
            this.btnRotarArriba.Name = "btnRotarArriba";
            this.btnRotarArriba.Size = new System.Drawing.Size(100, 30);
            this.btnRotarArriba.Text = "↑ Arriba";
            this.btnRotarArriba.UseVisualStyleBackColor = true;
            this.btnRotarArriba.Click += new System.EventHandler(this.btnRotarArriba_Click);

            // Botón Rotar Abajo
            this.btnRotarAbajo.Location = new System.Drawing.Point(90, 90);
            this.btnRotarAbajo.Name = "btnRotarAbajo";
            this.btnRotarAbajo.Size = new System.Drawing.Size(100, 30);
            this.btnRotarAbajo.Text = "↓ Abajo";
            this.btnRotarAbajo.UseVisualStyleBackColor = true;
            this.btnRotarAbajo.Click += new System.EventHandler(this.btnRotarAbajo_Click);

            // Agregar controles al formulario
            this.Controls.Add(this.btnRotarIzquierda);
            this.Controls.Add(this.btnRotarDerecha);
            this.Controls.Add(this.btnRotarArriba);
            this.Controls.Add(this.btnRotarAbajo);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
