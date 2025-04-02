using System.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura3D_MVC.Models.Utils
{
    public static class JsonLoader
    {
        public static JsonObjectModel LoadFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<JsonObjectModel>(json);
        }
    }
}
