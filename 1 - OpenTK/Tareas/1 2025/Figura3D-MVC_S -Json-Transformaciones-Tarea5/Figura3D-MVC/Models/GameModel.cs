﻿// Se importa el espacio de nombres 'OpenTK', que contiene la funcionalidad básica de OpenTK (Open Toolkit), una librería para gráficos 3D, entre otras.
using Figura3D_MVC.Models;
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
        public float _rotationX { get; set; } = 0.0f;
        public float _rotationY { get; set; } = 0.0f;

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

        // Aquí se agrega la lista para almacenar los objetos JSON
        public List<ObjetoJsonDrawable> ObjetosJson { get; private set; } = new List<ObjetoJsonDrawable>();

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

                // Inicialización de objetos 3D con vértices
                List<JsonVertex> vertices = new List<JsonVertex>
                {
                    new JsonVertex { X = -1.0f, Y = -1.0f, Z = -1.0f },
                    new JsonVertex { X = 1.0f, Y = -1.0f, Z = -1.0f },
                    new JsonVertex { X = 1.0f, Y = 1.0f, Z = -1.0f },
                    new JsonVertex { X = -1.0f, Y = 1.0f, Z = -1.0f },
                    new JsonVertex { X = -1.0f, Y = -1.0f, Z = 1.0f },
                    new JsonVertex { X = 1.0f, Y = -1.0f, Z = 1.0f },
                    new JsonVertex { X = 1.0f, Y = 1.0f, Z = 1.0f },
                    new JsonVertex { X = -1.0f, Y = 1.0f, Z = 1.0f }
                };

                // Calcular el centro de masa de los vértices
                Vector3 centroDeMasa = CalcularCentroDeMasa(vertices);

                // Trasladar los vértices al cuadrante -X, -Y, -Z
                TrasladarVerticesAlCentroDeMasa(vertices, centroDeMasa);

                // Agregar el objeto 3D con el centro de masa ajustado
                Objetos.Add(new Objeto3D(new Vector3(0.8f, 0.5f, 0.0f), centroDeMasa));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el modelo: " + ex.Message);
            }
        }

        // Método para calcular el centro de masa de una lista de vértices
        public Vector3 CalcularCentroDeMasa(List<JsonVertex> vertices)
        {
            float sumX = 0, sumY = 0, sumZ = 0;
            int count = vertices.Count;

            foreach (var vertex in vertices)
            {
                sumX += vertex.X;
                sumY += vertex.Y;
                sumZ += vertex.Z;
            }

            return new Vector3(sumX / count, sumY / count, sumZ / count);
        }

        // Método para trasladar los vértices al centro de masa en el cuadrante -X, -Y, -Z
        public void TrasladarVerticesAlCentroDeMasa(List<JsonVertex> vertices, Vector3 centroDeMasa)
        {
            // Traslación para mover el centro de masa al cuadrante -X, -Y, -Z
            Vector3 traslacion = new Vector3(-centroDeMasa.X - 1.0f, -centroDeMasa.Y - 1.0f, -centroDeMasa.Z - 1.0f);

            // Aplicar la traslación a cada vértice
            foreach (var vertex in vertices)
            {
                vertex.X += traslacion.X;
                vertex.Y += traslacion.Y;
                vertex.Z += traslacion.Z;
            }
        }

        public class GameModelSaveData
        {
            public List<Objeto3DData> Objetos { get; set; }

            public class Objeto3DData
            {
                public float PosX { get; set; }
                public float PosY { get; set; }
                public float PosZ { get; set; }
                public float RotationX { get; set; }
                public float RotationY { get; set; }
            }
        }

        public GameModelSaveData GetSaveData()
        {
            var saveData = new GameModelSaveData();
            saveData.Objetos = new List<GameModelSaveData.Objeto3DData>();

            foreach (var objeto in Objetos)
            {
                var objetoData = new GameModelSaveData.Objeto3DData
                {
                    PosX = objeto.Posicion.X,
                    PosY = objeto.Posicion.Y,
                    PosZ = objeto.Posicion.Z,
                    RotationX = this.RotationX,  // Usa la propiedad pública RotationX
                    RotationY = this.RotationY   // Usa la propiedad pública RotationY
                };
                saveData.Objetos.Add(objetoData);
            }

            return saveData;
        }

        public void AgregarObjetoJson(ObjetoJsonDrawable objeto)
        {
            ObjetosJson.Add(objeto);
        }

        public GameState GetGameState()
        {
            GameState state = new GameState();

            foreach (var obj in ObjetosJson)
            {
                state.Objetos.Add(new ObjetoJsonGuardado
                {
                    Nombre = obj.Modelo.Nombre,
                    PosX = obj.Posicion.X,
                    PosY = obj.Posicion.Y,
                    PosZ = obj.Posicion.Z,
                    RotX = obj.Rotacion.X,
                    RotY = obj.Rotacion.Y
                });
            }

            return state;
        }

        public void AplicarGameState(GameState state, JsonObjectModel baseModel)
        {
            ObjetosJson.Clear();

            foreach (var guardado in state.Objetos)
            {
                var objeto = new ObjetoJsonDrawable(baseModel)
                {
                    Posicion = new Vector3(guardado.PosX, guardado.PosY, guardado.PosZ),
                    Rotacion = new Vector3(guardado.RotX, guardado.RotY, 0)
                };

                ObjetosJson.Add(objeto);
            }
        }


    }
}
