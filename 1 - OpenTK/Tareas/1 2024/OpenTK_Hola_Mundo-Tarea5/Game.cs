using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK_Hola_Mundo.Utilities;

namespace OpenTK_Hola_Mundo
{
    public class Game : GameWindow
    {
        //Stage stage;

        float theta = 0.0f;

        List<IDrawable> items;

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

            items = new List<IDrawable>();
            //stage = ObjectFile.Load<Stage>("stage.json");
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Translate(0.0f, 0.0f, -45.0f);
            GL.Rotate(25.0f, 1.0, 0.0, 0.0);
            GL.Rotate(theta, 0.0, 0.5, 0.0);

            Axises.Draw(new Vertex(0, 0, 0), 30);

            //Object tv = stage.objects["tv-1"];
            //tv.Rotate("y", theta);
            //stage.Draw();
            //stage.Rotate("y", theta);

            foreach (IDrawable item in items)
            {
                item.Draw();
            }

            //stage.Rotate("y", 1);

            //tv.Scale(1.01f);

            theta += 1.0f;
            if (theta > 360) theta -= 360;

            Context.SwapBuffers();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            GL.Frustum(-1.0f, 1.0f, -1.0f, 1.0f, 0.8f, 100.0f);
            
            GL.MatrixMode(MatrixMode.Modelview);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }

            if ((input.IsKeyDown(Key.ControlLeft) || input.IsKeyDown(Key.ControlRight)) && input.IsKeyDown(Key.O))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = false; // Permitir seleccionar un solo archivo
                DialogResult result = openFileDialog.ShowDialog();

                // Si se selecciona un archivo
                if (result == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    Console.WriteLine("Archivo seleccionado: " + selectedFile);

                    AddItem(selectedFile);
                }
            }


        }

        private void AddItem(string filepath)
        {
            string msg = "";
            try
            {
                items.Add(ObjectFile.Load<Stage>(filepath));
                return;
            }
            catch (Exception ex)
            {
                msg += "1. " + ex.Message + "\n";
            }
            try
            {
                items.Add(ObjectFile.Load<Object>(filepath));
                return;
            }
            catch (Exception ex)
            {
                msg += "2. " + ex.Message;
            }

            MessageBox.Show(msg, "Error al cargar el archivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
