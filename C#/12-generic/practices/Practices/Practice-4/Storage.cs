using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_4
{
    public class Storage<T>
    {
        public static T Value { get; set; }
        public Storage()
        {
            Value=default(T);
        }
        public Storage(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return $"{ Value.GetType().FullName}: { Value}";
        }

    }
}
