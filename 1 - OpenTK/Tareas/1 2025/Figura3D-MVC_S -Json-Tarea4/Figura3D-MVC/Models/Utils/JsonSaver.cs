using Newtonsoft.Json;
using System;
using System.IO;

namespace Figura3D_MVC.Models.Utils
{
    public static class JsonSaver
    {
        // Método para guardar datos a un archivo JSON
        public static void SaveToFile(string filePath, object data)
        {
            try
            {
                // Serializa el objeto `data` a una cadena JSON
                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);

                // Guarda la cadena JSON en un archivo
                File.WriteAllText(filePath, jsonData);
                Console.WriteLine("Archivo guardado correctamente en: " + filePath);
            }
            catch (Exception ex)
            {
                // Si ocurre un error al guardar, muestra el mensaje
                Console.WriteLine("Error al guardar el archivo JSON: " + ex.Message);
            }
        }
    }
}
