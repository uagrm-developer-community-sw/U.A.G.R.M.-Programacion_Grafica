using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1
{
    public interface IDrawable
    {
        void Draw(); // metodo para dibujar el objeto en la escena (abstracto)

        void Translate(float x, float y, float z); // metodo para trasladar el objeto en la escena (abstracto)

        void Scale(float n); // metodo para escalar el objeto en la escena (abstracto)

        void Rotate(string axis, float grades); // metodo para rotar el objeto en la escena (abstracto)
    }
}
