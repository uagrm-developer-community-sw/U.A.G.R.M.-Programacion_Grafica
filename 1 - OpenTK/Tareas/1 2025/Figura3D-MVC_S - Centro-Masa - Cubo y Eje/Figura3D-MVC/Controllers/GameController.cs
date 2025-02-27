// Se importa el espacio de nombres 'Models', que contiene la lógica de negocio del juego (modelo).
using crearFigruas3D.Models;
// Se importa el espacio de nombres 'Views', que contiene la lógica de presentación del juego (vista).
using crearFigruas3D.Views;
using System;
using System.Windows.Forms;

// Definición del espacio de nombres 'Controllers', donde se encuentra el controlador principal del juego.
namespace crearFigruas3D.Controllers
{
    // Definición de la clase 'GameController', que es responsable de manejar la lógica entre el modelo y la vista.
    public class GameController
    {
        // Declaración de la variable privada '_model' de tipo 'GameModel'. Esta variable almacenará los datos y la lógica del modelo.
        private GameModel _model;
        // Declaración de la variable privada '_view' de tipo 'GameView'. Esta variable manejará la representación visual del modelo.
        private GameView _view;

        // Constructor de la clase 'GameController', donde se inicializan el modelo y la vista.
        public GameController()
        {
            try
            { 
                // Se crea una nueva instancia del modelo (GameModel), que manejará los datos del juego.
                _model = new GameModel();
                // Se crea una nueva instancia de la vista (GameView), pasando el modelo, el tamaño de la ventana y el título de la ventana.
                _view = new GameView(_model, 800, 600, "Figura 3D");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el controlador: " + ex.Message);
            }
        }

        // Método para rotar el modelo hacia la izquierda. Decrementa la propiedad 'RotationY' del modelo en 5 grados.
        public void RotateLeft()
        {
            try
            {
                _model.RotationY -= 5.0f;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rotar a la izquierda: " + ex.Message);
            }
        }

        // Método para rotar el modelo hacia la derecha. Incrementa la propiedad 'RotationY' del modelo en 5 grados.
        public void RotateRight()
        {
            try
            {
                _model.RotationY += 5.0f;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rotar a la derecha: " + ex.Message);
            }
        }

        // Método para rotar el modelo hacia arriba. Decrementa la propiedad 'RotationX' del modelo en 5 grados.
        public void RotateUp()
        {
            try
            {
                _model.RotationX -= 5.0f;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rotar hacia arriba: " + ex.Message);
            }
        }

        // Método para rotar el modelo hacia abajo. Incrementa la propiedad 'RotationX' del modelo en 5 grados.
        public void RotateDown()
        {
            try
            {
                _model.RotationX += 5.0f;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rotar hacia abajo: " + ex.Message);
            }
        }

        // Método que inicia la vista, ejecutando el bucle de renderizado de OpenTK.
        public void Run()
        {
            try
            {
                // Llama al método 'Run' de la vista, que ejecuta la vista con 60 fotogramas por segundo.
                // Este método es donde OpenTK maneja la actualización y renderización de la escena 3D.
                _view.Run(60.0); // OpenTK ahora se ejecuta en el hilo principal sin errores
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la vista: " + ex.Message);
            }
        }
    }
}
