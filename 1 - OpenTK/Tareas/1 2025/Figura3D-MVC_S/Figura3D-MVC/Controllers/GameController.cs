using crearFigruas3D.Models;
using crearFigruas3D.Views;

namespace crearFigruas3D.Controllers
{
    public class GameController
    {
        private GameModel _model;
        private GameView _view;

        public GameController()
        {
            _model = new GameModel();
            _view = new GameView(_model, 800, 600, "Figura 3D");
        }

        public void RotateLeft() => _model.RotationY -= 5.0f;
        public void RotateRight() => _model.RotationY += 5.0f;
        public void RotateUp() => _model.RotationX -= 5.0f;
        public void RotateDown() => _model.RotationX += 5.0f;

        public void Run()
        {
            _view.Run(60.0); // OpenTK ahora se ejecuta en el hilo principal sin errores
        }


    }
}
