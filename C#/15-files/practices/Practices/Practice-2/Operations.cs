using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice_2
{
    public class Operations
    {
        private static string Practice2 = @"d:\Practice2.txt";

        public delegate void driveInfo(DriveInfo[] d);
        public delegate void Help();
        
        
        public static Help helpOut = new Help(HelpOutput);
        public static driveInfo DriveInformation = new driveInfo(InfoOutput);
       
        public static void InfoOutput(DriveInfo[] drive)
        {
            try
            {
                foreach (var d in drive)
                {
                    SaveData("Drive " + d.Name);

                    Console.WriteLine("Drive " + d.Name);

                    SaveData("Type: " + d.DriveType);
                    Console.WriteLine("Type: " + d.DriveType);
                    if (d.IsReady == true)
                    {
                        SaveData("Volume: " + d.VolumeLabel);
                        Console.WriteLine("Volume: " + d.VolumeLabel);

                        SaveData("Label: " + d.DriveFormat);
                        Console.WriteLine("Label: " + d.DriveFormat);

                        SaveData("Free space: " + d.AvailableFreeSpace + " bytes");
                        Console.WriteLine("Free space: " + d.AvailableFreeSpace + " bytes");
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void HelpOutput()
        {
            Console.WriteLine("HELP Commands list");
            Console.WriteLine("DISK Displays detailed disks information");
            Console.WriteLine("cd-new path");
            Console.WriteLine("dir-get info");
            Console.WriteLine("EXIT Exit");
        }

        public static void SaveData(string data)
        {
            data += "\n";
            using var fstream = new FileStream(Practice2, FileMode.Append, FileAccess.Write);
            var bytes = System.Text.Encoding.Default.GetBytes(data);
            fstream.Write(bytes, 0, bytes.Length);
            
        }

        public static void DirectorySearch(string dir)
        {
            try
            {

                foreach (string f in Directory.GetFiles(dir))
                {
                    Console.WriteLine(File.GetCreationTime(f) + "  "+ "<Files>"+ Path.GetFileName(f));
                    SaveData(File.GetCreationTime(f).ToString() + "  " + "<Files>" + Path.GetFileName(f).ToString()+"\n");
                }
                foreach (string d in Directory.GetDirectories(dir))
                {
                    Console.WriteLine(Directory.GetCreationTime(d) + "  " + "<dir>" + Path.GetFileName(Path.GetDirectoryName(d)));
                    SaveData(Directory.GetCreationTime(d).ToString() + "  " + "<dir>" + Path.GetFileName(Path.GetDirectoryName(d)).ToString()+"\n");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

