﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Model;

namespace Tutorial_1.Services.Interfaces
{
    public interface IFileService
    {
        void SaveToFile(IEnumerable<Contact> contacts);
    }
}
