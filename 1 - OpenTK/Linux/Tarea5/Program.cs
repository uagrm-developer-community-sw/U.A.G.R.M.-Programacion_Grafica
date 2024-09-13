
namespace Tarea5 // Cambiar por el nombre de la carpeta que contiene el proyecto
{
    public class Program // Clase principal de la aplicación (entry point)
    {
        static void Main(string[] args) // Método principal de la aplicación (entry point)
        {
            using (Game game = new Game(800, 600, "Letra T")) // 800x600 pixels de resolución
            {
                game.Run(60.0); // 60 fotogramas por segundo (FPS)

            }
        }
    }
}
