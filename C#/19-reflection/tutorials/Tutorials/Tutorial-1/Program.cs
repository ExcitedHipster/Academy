using System;
using System.Linq;
using System.Reflection;

namespace Tutorial_1
{
    class Program
    {
        private const string Tab = "\t";
        public static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes();

            types = types.Reverse().ToArray();

            foreach (Type type in types)
            {
                Console.WriteLine("Class: {0}", type.Name);
                MethodInfo[] methods = type.GetMethods();

                foreach (var method in methods)
                {
                    var name = method.Name;
                    Console.WriteLine(Tab + "Method: " + name);

                    var parameters = method.GetParameters();
                    foreach (var parameter in parameters)
                    {
                        var paramName = parameter.Name;
                        var paramType = parameter.ParameterType;
                        Console.WriteLine(Tab + Tab + "Parameter: {0} | Type:{1}", paramName, paramType);
                    }
                }

                Console.WriteLine();
            }
        }

        public static void JustForFun()
        {

        }
    }
}
