using System;
using System.Collections.Generic;
using System.Text;
namespace Tutorial_1
{
    interface ISerializer<T>
    {
        void Serialize(T instance);
        T Deserialize();
    }
}