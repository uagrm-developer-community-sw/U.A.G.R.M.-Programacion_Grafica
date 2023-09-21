using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using System.Collections.Generic;
using System;
namespace PGrafica
{
    class Program
    {
        static void Main()
        {
       
            var nativeWindowSettings = new NativeWindowSettings()
            {
                Size = new Vector2i(1920, 1080),
                Title = "LearnOpenTK - Creating a Window",
                // This is needed to run on macos
                Flags = ContextFlags.ForwardCompatible,
            };
            using var game = new Game(GameWindowSettings.Default, nativeWindowSettings);
            game.Run();
        }
    }
}
