using System;

namespace Tutorial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                var batumiValidator = new TemperatureValidator(33);
                var tbilisiValidator = new TemperatureValidator(-1000);

                Console.WriteLine(batumiValidator.Temperature);
                Console.WriteLine(tbilisiValidator.Temperature);
            }

            

            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("IndexOutOfRange");
            }

            catch (IncredibleTemperatureException e)
            {

                Console.WriteLine(e.Message);
            }
            
            catch (Exception e)
            {

                Console.WriteLine("General Exception");
            }
        }
    }
}
