using Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practices.Services
{
    public interface IFileServices
    {
        void SaveToFile(AccountInfo account);
        string GetFile();
    }
}
