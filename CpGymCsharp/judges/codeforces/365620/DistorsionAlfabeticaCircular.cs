using System;
using System.Diagnostics;
using CpGymCsharp.interfaces;
using CpGymCsharp.utils;

namespace CpGymCsharp.judges.codeforces
{
    public class DistorsionAlfabeticaCircular : IBaseProblem
    {
        internal static readonly IBaseProblem Instance;
        private DistorsionAlfabeticaCircular() {}
        static DistorsionAlfabeticaCircular()
        {
            Instance = new DistorsionAlfabeticaCircular();
        }

        public static string Solve(string candidate)
        {
            if (candidate.Length != 26) return "imposible";

            string completeAlpha = "abcdefghijklmnopqrstuvwxyz";
            int bestMinChanges = 26;
            for (int i = 0; i < 26; i++)
            {
                string firstPart = completeAlpha.Substring(0, 26 - i);
                string secondPart = completeAlpha.Substring(26 - i);
                string circularString = secondPart + firstPart;
                int countChanges = 0;
                for (int k = 0; k < 26; k++)
                {
                    if (circularString[k] != candidate[k]) countChanges++;
                }
                bestMinChanges = Math.Min(bestMinChanges, countChanges);
            }

            return bestMinChanges.ToString();
        }

        public void Run(string pathToAppend)
        {
            string fileLocation = Helper.Combine(pathToAppend, "judges/codeforces/365620");
            Runner.Run(fileLocation, () =>
            {
                int k = int.Parse(Console.ReadLine()!);
                while (k-- > 0)
                {
                    string candidate = Console.ReadLine();
                    Console.WriteLine(Solve(candidate));
                }
            });
        }
    }
}
