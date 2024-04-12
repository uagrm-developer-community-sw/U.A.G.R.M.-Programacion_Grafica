using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;

namespace ConsoleApp1
{
    public class Window : GameWindow
    {
		Stage stage;


		// Constructor para la clase de ventana que toma el ancho, la altura y el título de la ventana
        public Window(int widht, int height, string title) : base(widht, height, GraphicsMode.Default, title){}

        protected override void OnLoad(EventArgs e) // método que se llama cuando se carga la ventana
        {
			base.OnLoad(e);
			//GL.ClearColor(0.2f, 0.5f, 0.5f, 0.5f);
			GL.ClearColor(Color4.Black);
			//GL.Enable(EnableCap.DepthTest);

			stage = new Stage(); // create a new stage 
			//Object3D floor = new Object3D(new float[3] { 0.0f, -0.25f, 0.0f }, Floor.GetFaces());
			//Object3D house = new Object3D(new float[3] { -0.4f, -0.25f, -0.1f }, House.GetFaces());
			//Object3D car = new Object3D(new float[3] { 0.6f, -0.2f, 0.2f }, Car.GetFaces());
			Object3D tv = new Object3D(new float[3] { 0.0f, 0.0f, 0.0f }, Tv.GetFaces());

			//Object3D radio = new Object3D(new float[3] { 0.0f, 0.0f, 0.0f }, Radio.GetFaces());

			//stage.addObject(house);
			//stage.addObject(floor);
			//stage.addObject(car);

			stage.addObject(tv);
			//stage.addObject(radio);
		}

		protected override void OnRenderFrame(FrameEventArgs e)
		{
			//base.OnRenderFrame(e);
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			//GL.Enable(EnableCap.DepthTest);
			GL.LoadIdentity();
            GL.Rotate(10.0, 1.0, 0.0, 0.0);
            GL.Rotate(45.0, 0.0, -1.0, 0.0);

			//Axes3D.drawAxes();
            stage.draw();
            Context.SwapBuffers();

			base.OnRenderFrame(e);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			GL.Viewport(0, 0, Width, Height);
		}

		protected override void OnUnload(EventArgs e)
		{
			base.OnUnload(e);
		}
	}
}
