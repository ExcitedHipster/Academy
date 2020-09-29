using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    public class Close : Operations, IDisposable
    {
        public Close()
        {
            Console.WriteLine("Your account has been successfully closed.");
            resultOutput();
        }
        public void Dispose()
        {
            balance = default;
            global = default;
            isNumber = false;
            result = 0;
        }

    }
}
