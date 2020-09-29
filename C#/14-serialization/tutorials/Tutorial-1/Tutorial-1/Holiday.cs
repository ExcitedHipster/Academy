using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
namespace Tutorial_1
{
    [Serializable]
    public class Holiday
    {
        public Holiday()
        {
        }
        public Holiday(DateTime date, string designation, string note = default, bool isDayOff = default)
        {
            Date = date;
            Designation = designation;
            IsDayOff = isDayOff;
            Note = note;
            Console.WriteLine("Holiday object was created:");
            Console.WriteLine();
        }
        public DateTime Date { get; set; }
        [XmlAttribute]
        public string Designation { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsDayOff { get; set; }
        [JsonRequired]
        [XmlIgnore]
        public string Note { get; set; }
        public override string ToString()
        {
            return $"Date: {Date} \nDesignation: {Designation} \nNote: {Note} \n Day off: {IsDayOff}";
        }
    }
}