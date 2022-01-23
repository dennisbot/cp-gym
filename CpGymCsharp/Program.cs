using System;
using CpGymCsharp.interfaces;
using CpGymCsharp.judges.codeforces;
using CpGymCsharp.judges.leetcode;
using CpGymCsharp.judges.uva;

namespace CpGymCsharp
{
    static class Program
    {
        static string GetExtraPath(string[] args)
        {
            string extraPath = "";
            // we add an extra arguments in the IDE, not required when running from terminal
            if (args.Length > 0) extraPath = "../../../";
            return extraPath;
        }
        static void Main(string[] args)
        {
            // DeciBinary.Instance.Run(GetExtraPath(args));
            Spiderman.Instance.Run(GetExtraPath(args));
        }
    }
}
