using AutomaticGenerator.Models.Generators.FaceBooks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator
{
    public class JsonStream
    {
        private StreamReader _streamReader;

        private string _filePath;

        public JsonStream(string file)
        {
            SetFilPath(file);
        }

        public void SetFilPath(string file)
        {
            _filePath = file;
        }

        public string GetFilePath()
        {
            return _filePath;
        }

        public string Read()
        {
            _streamReader = new StreamReader(_filePath);

            var read = _streamReader.ReadToEnd();

            _streamReader.Close();

            return read;
        }

        public void Write(string content)
        {        
            try
            {
                StreamWriter streamWriter = new StreamWriter(_filePath);
                streamWriter.WriteLine(content);
                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public async Task<string> ReadToEndAsync()
        {
            _streamReader = new StreamReader(_filePath);

            var read =  await _streamReader.ReadToEndAsync();

            _streamReader.Close();

            return read;
        }

        public List<T> ConvertJsonList<T>(string json)
        {
            _streamReader = new StreamReader(_filePath);

            var read = JsonConvert.DeserializeObject<List<T>>(json);

            _streamReader.Close();

            return read;
        }
    }
}
