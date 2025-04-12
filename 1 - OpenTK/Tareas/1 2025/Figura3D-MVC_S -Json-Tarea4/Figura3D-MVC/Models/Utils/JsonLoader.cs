using System.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura3D_MVC.Models.Utils
{
    public static class JsonLoader
    {
        public static JsonObjectModel LoadFromFile(string filePath)
        {
            try
            {
                // Leer el archivo JSON
                string jsonData = File.ReadAllText(filePath);

                // Deserializar el contenido JSON en un objeto de tipo JsonObjectModel
                var objetoJson = JsonConvert.DeserializeObject<JsonObjectModel>(jsonData);

                return objetoJson;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo JSON: " + ex.Message);
                return null; // En caso de error, retorna null
            }
        }


        public static T LoadFromFile<T>(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo JSON: " + ex.Message);
                return default;
            }
        }

    }
}
