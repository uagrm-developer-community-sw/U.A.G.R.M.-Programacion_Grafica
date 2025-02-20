// Se importa el espacio de nombres 'Models', que contiene la lógica de negocio del juego (modelo).
using crearFigruas3D.Models;
// Se importa el espacio de nombres 'Views', que contiene la lógica de presentación del juego (vista).
using crearFigruas3D.Views;

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
            // Se crea una nueva instancia del modelo (GameModel), que manejará los datos del juego.
            _model = new GameModel();
            // Se crea una nueva instancia de la vista (GameView), pasando el modelo, el tamaño de la ventana y el título de la ventana.
            _view = new GameView(_model, 800, 600, "Figura 3D");
        }

        // Método para rotar el modelo hacia la izquierda. Decrementa la propiedad 'RotationY' del modelo en 5 grados.
        public void RotateLeft() => _model.RotationY -= 5.0f;
        // Método para rotar el modelo hacia la derecha. Incrementa la propiedad 'RotationY' del modelo en 5 grados.
        public void RotateRight() => _model.RotationY += 5.0f;
        // Método para rotar el modelo hacia arriba. Decrementa la propiedad 'RotationX' del modelo en 5 grados.
        public void RotateUp() => _model.RotationX -= 5.0f;
        // Método para rotar el modelo hacia abajo. Incrementa la propiedad 'RotationX' del modelo en 5 grados.
        public void RotateDown() => _model.RotationX += 5.0f;

        // Método que inicia la vista, ejecutando el bucle de renderizado de OpenTK.
        public void Run()
        {
            // Llama al método 'Run' de la vista, que ejecuta la vista con 60 fotogramas por segundo.
            // Este método es donde OpenTK maneja la actualización y renderización de la escena 3D.
            _view.Run(60.0); // OpenTK ahora se ejecuta en el hilo principal sin errores
        }
    }
}
