namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Window window = new Window(800, 600, "OpenTK 3.3.1"))
            {
                window.Run(90.0);
            }
        }
    }
}
