namespace OpenTK_Hola_Mundo
{
    public interface IDrawable
    {
        void Draw();

        void Translate(float x, float y, float z);

        void Scale(float n);

        void Rotate(string axis, float grades);
    }
}
