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
            this.grpBxControlCubo = new System.Windows.Forms.GroupBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObtenerPosicio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.clrDlgTapas = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpBxControlCubo.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRotarIzquierda
            // 
            this.btnRotarIzquierda.BackColor = System.Drawing.SystemColors.Info;
            this.btnRotarIzquierda.Location = new System.Drawing.Point(18, 76);
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
            this.btnRotarDerecha.Location = new System.Drawing.Point(148, 76);
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
            this.btnRotarArriba.Location = new System.Drawing.Point(88, 36);
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
            this.btnRotarAbajo.Location = new System.Drawing.Point(88, 116);
            this.btnRotarAbajo.Name = "btnRotarAbajo";
            this.btnRotarAbajo.Size = new System.Drawing.Size(120, 30);
            this.btnRotarAbajo.TabIndex = 3;
            this.btnRotarAbajo.Text = "↓ Abajo";
            this.btnRotarAbajo.UseVisualStyleBackColor = false;
            this.btnRotarAbajo.Click += new System.EventHandler(this.btnRotarAbajo_Click);
            // 
            // grpBxControlCubo
            // 
            this.grpBxControlCubo.BackColor = System.Drawing.Color.Gainsboro;
            this.grpBxControlCubo.Controls.Add(this.btnRotarDerecha);
            this.grpBxControlCubo.Controls.Add(this.btnRotarIzquierda);
            this.grpBxControlCubo.Controls.Add(this.btnRotarAbajo);
            this.grpBxControlCubo.Controls.Add(this.btnRotarArriba);
            this.grpBxControlCubo.Location = new System.Drawing.Point(9, 17);
            this.grpBxControlCubo.Name = "grpBxControlCubo";
            this.grpBxControlCubo.Size = new System.Drawing.Size(292, 164);
            this.grpBxControlCubo.TabIndex = 4;
            this.grpBxControlCubo.TabStop = false;
            this.grpBxControlCubo.Text = "Controles Letra U";
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlControles.Controls.Add(this.groupBox1);
            this.pnlControles.Controls.Add(this.grpBxControlCubo);
            this.pnlControles.Location = new System.Drawing.Point(362, 12);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(334, 521);
            this.pnlControles.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnObtenerPosicio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxZ);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obtener Posicion Letra U";
            // 
            // btnObtenerPosicio
            // 
            this.btnObtenerPosicio.Location = new System.Drawing.Point(23, 135);
            this.btnObtenerPosicio.Name = "btnObtenerPosicio";
            this.btnObtenerPosicio.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerPosicio.TabIndex = 6;
            this.btnObtenerPosicio.Text = "Obtener";
            this.btnObtenerPosicio.UseVisualStyleBackColor = true;
            this.btnObtenerPosicio.Click += new System.EventHandler(this.btnObtenerPosicio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Z =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y =";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(49, 102);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(49, 26);
            this.textBoxZ.TabIndex = 3;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(50, 74);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(48, 26);
            this.textBoxY.TabIndex = 2;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(49, 42);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(49, 26);
            this.textBoxX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X =";
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(28, 462);
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(291, 45);
            this.trackBarY.TabIndex = 1;
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(28, 369);
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(291, 45);
            this.trackBarX.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.trackBarY);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.trackBarX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.trackBarZ);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 617);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Aqua;
            this.label10.Location = new System.Drawing.Point(39, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "FUNCION:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "TRANSLACION"});
            this.comboBox2.Location = new System.Drawing.Point(43, 249);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 28);
            this.comboBox2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(39, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "OBJETO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(50, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "SOBRE EL  Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(49, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "SOBRE EL  Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(49, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "SOBRE EL  X";
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(28, 548);
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(291, 45);
            this.trackBarZ.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CUBO"});
            this.comboBox1.Location = new System.Drawing.Point(43, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sALIRToolStripMenuItem.Text = "Salir";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "openFileDialog.Filter = \"Archivos JSON (*.json)|*.json\";";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(710, 629);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlControles);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "FIGURAS OPENTK";
            this.grpBxControlCubo.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private GroupBox grpBxControlCubo;
        private Panel pnlControles;
        private TrackBar trackBarX;
        private TrackBar trackBarY;
        private ColorDialog clrDlgTapas;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBoxZ;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private Label label1;
        private Label label6;
        private Button btnObtenerPosicio;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label7;
        private TrackBar trackBarZ;
        private Label label2;
        private Label label8;
        private Label label10;
        private ComboBox comboBox2;
        private Label label9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
    }
}
