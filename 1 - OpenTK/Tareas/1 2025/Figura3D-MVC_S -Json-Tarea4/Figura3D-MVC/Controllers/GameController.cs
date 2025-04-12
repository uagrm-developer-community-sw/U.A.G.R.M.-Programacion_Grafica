using crearFigruas3D.Models;
using Figura3D_MVC.Models.Utils;

using crearFigruas3D.Views;
using System;

using System.Drawing;

using System.Windows.Forms;
using System.Diagnostics;

namespace crearFigruas3D.Controllers
{
    public class GameController
    {
        private GameModel _model;

        private GameView _view;

        // Agrega esto en tu GameController.cs
        public GameView GameView => _view;


        public GameController()
        {
            try
            {
                _model = new GameModel();

                _view = new GameView(_model, 800, 600, "Figura 3D");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el controlador: " + ex.Message);
            }
        }

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

        public void Run()
        {
            try
            {
                _view.Run(60.0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la vista: " + ex.Message);
            }
        }

        public void SaveGameModel()
        {
            // Obtén los datos del modelo para guardar
            var saveData = _model.GetSaveData();

            // Llama a JsonSaver para guardar los datos en un archivo
            JsonSaver.SaveToFile("Resources/saveGame.json", saveData);
        }

       
        public void CargarObjetoJson()
        {
            var objeto = JsonLoader.LoadFromFile("Resources/objetos.json");

            if (objeto != null)
            {
                var objetoDrawable = new ObjetoJsonDrawable(objeto);
                _model.ObjetosJson.Add(objetoDrawable);
            }
            else
            {
                Debug.WriteLine("Error al cargar el objeto JSON.");
            }
        }

        public void GuardarEstado()
        {
            var estado = _model.GetGameState();
            JsonSaver.SaveToFile("Resources/saveGame.json", estado);
        }

        public void CargarEstado()
        {
            var estado = JsonLoader.LoadFromFile<GameState>("Resources/saveGame.json");

            if (estado != null)
            {
                var modeloBase = JsonLoader.LoadFromFile("Resources/objetos.json");
                _model.AplicarGameState(estado, modeloBase);
            }
        }




    }
}