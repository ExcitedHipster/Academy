using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
namespace Tutorial_1
{
    public class JsonSerializer<T> : ISerializer<T>
    {
        private const string FileName = "holiday.json";
        public void Serialize(T instance)
        {
            string jsonString = JsonConvert.SerializeObject(instance, Formatting.Indented);
            File.WriteAllText(FileName, jsonString);
            Console.WriteLine("Object was serialized in holiday.json");
        }
        public T Deserialize()
        {
            string jsonString = File.ReadAllText(FileName);
            var data = JsonConvert.DeserializeObject<T>(jsonString);
            Console.WriteLine("Object was deserialized in holiday.json");
            return data;
        }
    }
}