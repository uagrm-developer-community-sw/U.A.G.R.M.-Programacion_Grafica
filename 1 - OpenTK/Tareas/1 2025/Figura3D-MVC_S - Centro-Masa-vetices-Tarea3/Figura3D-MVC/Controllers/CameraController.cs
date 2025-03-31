using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using System;
using crearFigruas3D.Models;  // Importa el namespace donde está ULetterModel


namespace Figura3D_MVC.Controllers
{
    public class CameraController
    {
        private float cameraZoom = -5.0f;
        private float cameraPosX = 0.0f;
        private float cameraPosY = 0.0f;
        private float rotationXAxes = 0.0f;
        private float rotationSpeed = 0.1f;
        private float letterPosX = 0.0f;
        private float letterPosY = 0.0f;

        public float CameraZoom { get => cameraZoom; set => cameraZoom = value; }
        public float CameraPosX { get => cameraPosX; set => cameraPosX = value; }
        public float CameraPosY { get => cameraPosY; set => cameraPosY = value; }
        public float LetterPosX { get => letterPosX; set => letterPosX = value; }
        public float LetterPosY { get => letterPosY; set => letterPosY = value; }

        public CameraController() { }

        // Método para manejar el zoom con la rueda del mouse
        public void HandleMouseWheel(MouseWheelEventArgs e)
        {
            cameraZoom += e.Delta > 0 ? 0.1f : -0.1f;
            cameraZoom = MathHelper.Clamp(cameraZoom, -10.0f, -1.0f);
        }

        // Método para mover la cámara con el teclado
        public void HandleKeyboardMovement(KeyboardState keyboardState)
        {
            if (keyboardState.IsKeyDown(Key.A)) cameraPosX -= 0.1f;
            if (keyboardState.IsKeyDown(Key.D)) cameraPosX += 0.1f;
            if (keyboardState.IsKeyDown(Key.W)) cameraPosY += 0.1f;
            if (keyboardState.IsKeyDown(Key.S)) cameraPosY -= 0.1f;
        }

        // Método para mover la letra "U" con las teclas de dirección
        public void HandleLetterMovement(KeyboardState keyboardState)
        {
            if (keyboardState.IsKeyDown(Key.Up)) letterPosY += 0.1f;
            if (keyboardState.IsKeyDown(Key.Down)) letterPosY -= 0.1f;
            if (keyboardState.IsKeyDown(Key.Left)) letterPosX -= 0.1f;
            if (keyboardState.IsKeyDown(Key.Right)) letterPosX += 0.1f;
        }

        // Método para aplicar transformaciones de cámara
        public void ApplyCameraTransformations()
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(cameraPosX, cameraPosY, cameraZoom);
        }

        // Método para aplicar las transformaciones de la letra "U"
        public void ApplyLetterTransformations()
        {
            ULetterModel.Move(letterPosX, letterPosY);
        }
    }
}
