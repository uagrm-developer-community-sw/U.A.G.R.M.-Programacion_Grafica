// Se importa el espacio de nombres 'OpenTK', que contiene la funcionalidad básica de OpenTK (Open Toolkit), una librería para gráficos 3D, entre otras.
using OpenTK;
// Se importa el espacio de nombres 'OpenTK.Graphics', que proporciona clases y métodos relacionados con gráficos 3D, como la configuración de la pantalla y el contexto de renderizado.
using OpenTK.Graphics;
// Se importa el espacio de nombres 'OpenTK.Graphics.OpenGL', que contiene las funciones necesarias para interactuar con OpenGL, una API de gráficos 3D.
using OpenTK.Graphics.OpenGL;
// Se importa el espacio de nombres 'System', que incluye tipos básicos de .NET como `Console`, `DateTime`, y otros elementos fundamentales para el sistema.
using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Definición del espacio de nombres 'crearFigruas3D.Models', donde se maneja la lógica relacionada con los modelos del juego o aplicación.
namespace crearFigruas3D.Models
{
    // Definición de la clase 'GameModel', que se utiliza para manejar los datos del juego, como las rotaciones de la figura.
    public class GameModel
    {
        public struct Objeto3D
        {
            public Vector3 Posicion;
            public Vector3 CentroDeMasa;

            public Objeto3D(Vector3 posicion, Vector3 centroDeMasa)
            {
                Posicion = posicion;
                CentroDeMasa = centroDeMasa;
            }
        }

        // Se mantiene como lista, es adecuado
        public List<Objeto3D> Objetos { get; private set; } = new List<Objeto3D>();

        public float RotationX { get; set; } = 0.0f;
        public float RotationY { get; set; } = 0.0f;

        public GameModel()
        {
            try
            {
                // Inicialización de objetos 3D
                Objetos.Add(new Objeto3D(new Vector3(0.8f, 0.5f, 0.0f), new Vector3(0.8f, 0.5f, 0.0f)));
                Objetos.Add(new Objeto3D(new Vector3(1.2f, 0.8f, 0.0f), new Vector3(1.2f, 0.8f, 0.0f)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el modelo: " + ex.Message);
            }
        }
    }
}
