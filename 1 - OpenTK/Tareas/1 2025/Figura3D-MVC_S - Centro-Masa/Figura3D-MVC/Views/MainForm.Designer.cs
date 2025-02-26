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
            try 
            { 
                // Crear las instancias de los botones.
                this.btnRotarIzquierda = new System.Windows.Forms.Button();
                this.btnRotarDerecha = new System.Windows.Forms.Button();
                this.btnRotarArriba = new System.Windows.Forms.Button();
                this.btnRotarAbajo = new System.Windows.Forms.Button();

                // Configuración de la ventana del formulario. 
                this.SuspendLayout();

                // Configuración del botón 'btnRotarIzquierda'.
                this.btnRotarIzquierda.Text = "← Izquierda";  // Establece el texto que aparecerá en el botón.
                this.btnRotarIzquierda.Location = new System.Drawing.Point(20, 50);  // Establece la posición del botón en la ventana.
                this.btnRotarIzquierda.Size = new System.Drawing.Size(120, 30);  // Establece el tamaño del botón (ancho y alto).
                this.btnRotarIzquierda.Click += new System.EventHandler(this.btnRotarIzquierda_Click);  // Define el evento al hacer clic (asociando el manejador de eventos).

                // Configuración del botón 'btnRotarDerecha'.
                this.btnRotarDerecha.Text = "→ Derecha";
                this.btnRotarDerecha.Location = new System.Drawing.Point(150, 50);
                this.btnRotarDerecha.Size = new System.Drawing.Size(120, 30);
                this.btnRotarDerecha.Click += new System.EventHandler(this.btnRotarDerecha_Click);

                // Configuración del botón 'btnRotarArriba'.
                this.btnRotarArriba.Text = "↑ Arriba";
                this.btnRotarArriba.Location = new System.Drawing.Point(90, 10);
                this.btnRotarArriba.Size = new System.Drawing.Size(120, 30);
                this.btnRotarArriba.Click += new System.EventHandler(this.btnRotarArriba_Click);

                // Configuración del botón 'btnRotarAbajo'.
                this.btnRotarAbajo.Text = "↓ Abajo";
                this.btnRotarAbajo.Location = new System.Drawing.Point(90, 90);
                this.btnRotarAbajo.Size = new System.Drawing.Size(120, 30);
                this.btnRotarAbajo.Click += new System.EventHandler(this.btnRotarAbajo_Click);

                // Establecer alineación de texto en los botones (centrado).
                this.btnRotarIzquierda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.btnRotarDerecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.btnRotarArriba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.btnRotarAbajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                // Agregar los botones al formulario para que se muestren en la interfaz gráfica.
                this.Controls.Add(this.btnRotarIzquierda);
                this.Controls.Add(this.btnRotarDerecha);
                this.Controls.Add(this.btnRotarArriba);
                this.Controls.Add(this.btnRotarAbajo);

                // Finaliza la configuración del formulario y aplica los cambios.
                this.ResumeLayout(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar los componentes: " + ex.Message);
            }
        }
    }
}
