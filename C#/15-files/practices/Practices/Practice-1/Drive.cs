﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice_1
{
    public class Drive:Operations
    {
        
        public Drive()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            DriveInformation(allDrives);
        }
    }
}
