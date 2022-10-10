using AutomaticGenerator.Models.Generators.FaceBook;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator
{
    public static class JsonReader
    {
        private static StreamReader _streamReader;

        public static void Load(string file)
        {
            _streamReader = new StreamReader(file);            
        }

        public static string Read()
        {
            return _streamReader.ReadToEnd();
        }

        public static async Task<string> ReadToEndAsync()
        {
            return await _streamReader.ReadToEndAsync();
        }

        public static List<T> ConvertJsonList<T>(string json)
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
