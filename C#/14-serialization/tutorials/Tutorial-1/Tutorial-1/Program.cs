using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
namespace Tutorial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var holiday = new Holiday(DateTime.Now.AddDays(2), "Saturday");
            var binarySerializer = new BinarySerializer<Holiday>();
            DoImpressiveSerializationWork(holiday, binarySerializer);
            var xmlHoliday = new Holiday(DateTime.Now.AddDays(3), "Sunday", "Sunday is chill", true);
            var xmlSerializer = new XmlCustomSerializer<Holiday>();
            DoImpressiveSerializationWork(xmlHoliday, xmlSerializer);
            var jsonHoliday = new Holiday(DateTime.Now.AddDays(7), "Some Day", "This is required", isDayOff: false);
            var jsonSerializer = new JsonSerializer<Holiday>();
            DoImpressiveSerializationWork(jsonHoliday, jsonSerializer);
        }
        private static void DoImpressiveSerializationWork(Holiday holiday, ISerializer<Holiday> serializer)
        {
            Console.WriteLine(holiday);
            Console.WriteLine();
            serializer.Serialize(holiday);
            var deserializedHoliday = serializer.Deserialize();
            Console.WriteLine();
            Console.WriteLine(deserializedHoliday);
        }
    }
}