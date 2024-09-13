namespace Tarea5
{
    public interface IDrawable // Interfaz para objetos que se pueden dibujar
    {
        void Draw(); // Método para dibujar el objeto

        void Translate(float x, float y, float z); // Método para trasladar el objeto

        void Scale(float n); // Método para escalar el objeto (aumentar o disminuir su tamaño)

        void Rotate(String axis, float grades); // Método para rotar el objeto (en grados) en un eje específico
    }
}