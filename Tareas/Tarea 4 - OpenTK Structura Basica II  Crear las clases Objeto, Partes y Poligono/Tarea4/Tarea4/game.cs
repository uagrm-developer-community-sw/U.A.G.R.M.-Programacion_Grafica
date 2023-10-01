using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class game: GameWindow
    {
        private Double theta = 0; //angulo de rotacion
        cuarto cuartito;
        cuarto cuartito2;
        public void thetaInc() //incrementa el angulo de rotacion
        {
            if (theta == 360)
            {
                theta = 0;
            }
            else
            {
                theta += 1;
            }
        }
        public game(int widht, int height, string title) : base(widht, height, GraphicsMode.Default, title) //constructor
        {
        }

        protected override void OnLoad(EventArgs e) //se llama cuando se carga la ventana
        {
            base.OnLoad(e); //llamamos al metodo de la clase padre
            objeto auto = new objeto(2.0, 2.0, 0.0); //creamos un objeto
            objeto pared = new objeto(2.0, 2.0, 0.0); //creamos un objeto
            objeto repisa = new objeto(2.0, 2.0, 0.0); //creamos un objeto

            Color colorCelestevidrio = Color.FromArgb(1, 168, 204, 215); //creamos un color
            poligono vidrioDelantero = new poligono(colorCelestevidrio); //creamos un poligono
            vidrioDelantero.addVertice(-0.4f, 0.5f, 1.5f);
            vidrioDelantero.addVertice(-0.4f, 0.75f, 1.25f);
            vidrioDelantero.addVertice(-0.2f, 0.75f, 1.25f);
            vidrioDelantero.addVertice(-0.2f, 0.5f, 1.5f);
            poligono vidrioTracero = new poligono(colorCelestevidrio);
            vidrioTracero.addVertice(-0.4f, 0.75f, 0.75f);
            vidrioTracero.addVertice(-0.4f, 0.5f, 0.5f);
            vidrioTracero.addVertice(-0.2f, 0.5f, 0.5f);
            vidrioTracero.addVertice(-0.2f, 0.75f, 0.75f);
            Color rojoAuto = Color.FromArgb(1, 170, 51, 51);
            poligono techo = new poligono(rojoAuto);
            techo.addVertice(-0.4f, 0.75f, 0.75f);
            techo.addVertice(-0.4f, 0.5f, 0.5f);
            techo.addVertice(-0.2f, 0.5f, 0.5f);
            techo.addVertice(-0.2f, 0.75f, 0.75f);
            poligono cabinaizquierda = new poligono(rojoAuto);
            cabinaizquierda.addVertice(-0.4f, 0.75f, 1.25f);
            cabinaizquierda.addVertice(-0.4f, 0.5f, 1.5f);
            cabinaizquierda.addVertice(-0.4f, 0.5f, 0.5f);
            cabinaizquierda.addVertice(-0.4f, 0.75f, 0.75f);
        }
    }
}
