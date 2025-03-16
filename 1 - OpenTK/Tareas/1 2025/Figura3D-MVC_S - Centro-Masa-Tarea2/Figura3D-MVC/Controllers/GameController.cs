
using crearFigruas3D.Models;

using crearFigruas3D.Views;

using System;

using System.Drawing;

using System.Windows.Forms;


namespace crearFigruas3D.Controllers
{
    
    public class GameController
    {
        
        
        private GameModel _model;

        
        
        private GameView _view;


        
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
    }
}
