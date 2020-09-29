using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice_1
{
    public class Operations
    {
        private const string Practice1 = @"d:\Practice1.txt";

        public delegate void driveInfo(DriveInfo[] d);
        public delegate void Help();

        public static driveInfo DriveInformation = new driveInfo(InfoOutput);
        public static Help helpOut = new Help(HelpOutput);
        public static void InfoOutput(DriveInfo[] drive)
        {

            foreach (var d in drive)
            {
                SaveData("Drive " + d.Name);

                Console.WriteLine("Drive " + d.Name);

                SaveData("Type: " + d.DriveType);
                Console.WriteLine("Type: " + d.DriveType);
                if (d.IsReady == true)
                {
                    SaveData("Volume: "+ d.TotalFreeSpace);
                    Console.WriteLine("Volume: " + d.TotalFreeSpace);

                    SaveData("Label: "+ d.DriveFormat);
                    Console.WriteLine("Label: " + d.DriveFormat);

                    SaveData("Free space: " + d.AvailableFreeSpace + " bytes");
                    Console.WriteLine("Free space: " + d.AvailableFreeSpace + " bytes");
                }
            }
        }
        public static void HelpOutput()
        {
            Console.WriteLine("HELP Commands list");
            Console.WriteLine("DISK Displays detailed disks information");
            Console.WriteLine("EXIT Exit");
        }
        public static void SaveData(string data)
        {
            data += "\n";
            using var fstream = new FileStream(Practice1, FileMode.Append, FileAccess.Write);
            var bytes = System.Text.Encoding.Default.GetBytes(data);
            fstream.Write(bytes, 0, bytes.Length);
            
        }
     


    }
}

