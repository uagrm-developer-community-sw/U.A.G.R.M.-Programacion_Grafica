// Definición del espacio de nombres 'crearFigruas3D.Views', que contiene la lógica de la vista del formulario.
using System;
using System.Windows.Forms;

namespace crearFigruas3D.Views
{
    // Clase parcial 'MainForm', que es la representación de la ventana del formulario en la aplicación.
    partial class MainForm
    {
        /// <summary>
        /// Requiere una variable del diseñador. 
        /// Esta variable mantiene los componentes del formulario, como botones, controles y otros objetos visuales.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Declaración de los botones que estarán en el formulario para rotar el modelo 3D.
        private System.Windows.Forms.Button btnRotarIzquierda;
        private System.Windows.Forms.Button btnRotarDerecha;
        private System.Windows.Forms.Button btnRotarArriba;
        private System.Windows.Forms.Button btnRotarAbajo;
        

        /// <summary>
        /// Limpia los recursos utilizados por el formulario.
        /// Este método se asegura de que los recursos como memoria y objetos sean liberados cuando ya no se necesiten.
        /// </summary>
        /// <param name="disposing">true si se deben eliminar los recursos administrados; false si no se deben eliminar.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                // Si se está eliminando el formulario y los recursos administrados no son nulos, se eliminan.
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error al liberar recursos: " + ex.Message);
            }
            // Llama al método base Dispose() para realizar la limpieza adicional.
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Método necesario para el soporte del diseñador - no modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        #endregion

        // Método para inicializar los componentes del formulario, como los botones y otros controles.
        private void InitializeComponent()
        {
            this.btnRotarIzquierda = new System.Windows.Forms.Button();
            this.btnRotarDerecha = new System.Windows.Forms.Button();
            this.btnRotarArriba = new System.Windows.Forms.Button();
            this.btnRotarAbajo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRotarIzquierda
            // 
            this.btnRotarIzquierda.BackColor = System.Drawing.SystemColors.Info;
            this.btnRotarIzquierda.Location = new System.Drawing.Point(29, 96);
            this.btnRotarIzquierda.Name = "btnRotarIzquierda";
            this.btnRotarIzquierda.Size = new System.Drawing.Size(120, 30);
            this.btnRotarIzquierda.TabIndex = 0;
            this.btnRotarIzquierda.Text = "← Izquierda";
            this.btnRotarIzquierda.UseVisualStyleBackColor = false;
            this.btnRotarIzquierda.Click += new System.EventHandler(this.btnRotarIzquierda_Click);
            // 
            // btnRotarDerecha
            // 
            this.btnRotarDerecha.BackColor = System.Drawing.SystemColors.Info;
            this.btnRotarDerecha.Location = new System.Drawing.Point(159, 96);
            this.btnRotarDerecha.Name = "btnRotarDerecha";
            this.btnRotarDerecha.Size = new System.Drawing.Size(120, 30);
            this.btnRotarDerecha.TabIndex = 1;
            this.btnRotarDerecha.Text = "→ Derecha";
            this.btnRotarDerecha.UseVisualStyleBackColor = false;
            this.btnRotarDerecha.Click += new System.EventHandler(this.btnRotarDerecha_Click);
            // 
            // btnRotarArriba
            // 
            this.btnRotarArriba.BackColor = System.Drawing.SystemColors.Info;
            this.btnRotarArriba.Location = new System.Drawing.Point(99, 56);
            this.btnRotarArriba.Name = "btnRotarArriba";
            this.btnRotarArriba.Size = new System.Drawing.Size(120, 30);
            this.btnRotarArriba.TabIndex = 2;
            this.btnRotarArriba.Text = "↑ Arriba";
            this.btnRotarArriba.UseVisualStyleBackColor = false;
            this.btnRotarArriba.Click += new System.EventHandler(this.btnRotarArriba_Click);
            // 
            // btnRotarAbajo
            // 
            this.btnRotarAbajo.BackColor = System.Drawing.SystemColors.Info;
            this.btnRotarAbajo.Location = new System.Drawing.Point(99, 136);
            this.btnRotarAbajo.Name = "btnRotarAbajo";
            this.btnRotarAbajo.Size = new System.Drawing.Size(120, 30);
            this.btnRotarAbajo.TabIndex = 3;
            this.btnRotarAbajo.Text = "↓ Abajo";
            this.btnRotarAbajo.UseVisualStyleBackColor = false;
            this.btnRotarAbajo.Click += new System.EventHandler(this.btnRotarAbajo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btnRotarDerecha);
            this.groupBox1.Controls.Add(this.btnRotarIzquierda);
            this.groupBox1.Controls.Add(this.btnRotarAbajo);
            this.groupBox1.Controls.Add(this.btnRotarArriba);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 216);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles CUBO";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(354, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 213);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duplicar Objetos";
            this.groupBox2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(204, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "PROGRAMACION GRAFICA";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1001, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "FIGURAS OPENTK";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
    }
}
