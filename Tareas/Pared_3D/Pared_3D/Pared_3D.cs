using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pared_3D
{
    internal class Pared_3D
    {
        GameWindow window;
        public Pared_3D(GameWindow window)
        {
            this.window = window;
            Start();
        }

        void Start()
        {
            window.Load += Loaded;
            window.Resize += resise;
            window.RenderFrame += renderF;
            window.Run(1.0/60.0);
        }

        void Loaded(object sender, EventArgs e)
        {

        }
    }

}
