using System;
using System.IO;

namespace CpGymCsharp.utils
{
    public class Helper
    {
        public static string Combine(params string[] path)
        {
            string fileLocation = Path.Combine(path);
            Console.WriteLine($"fileLocation = {fileLocation}");
            return fileLocation;
        }
    }
}
