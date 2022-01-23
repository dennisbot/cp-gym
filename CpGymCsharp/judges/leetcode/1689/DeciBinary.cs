using System;
using CpGymCsharp.interfaces;
using CpGymCsharp.utils;

namespace CpGymCsharp.judges.leetcode
{
    public class DeciBinary : IBaseProblem
    {
        internal static readonly IBaseProblem Instance;
        private DeciBinary() {}
        static DeciBinary()
        {
            Instance = new DeciBinary();
        }

        public static int MinPartitions(string number)
        {
            char ans = '0';
            for (var i = 0; i < number.Length; i++)
            {
                if (number[i] > ans) ans = number[i];
            }

            return int.Parse(ans.ToString());
        }

        public void Run(string pathToAppend)
        {
            string fileLocation = Helper.Combine(pathToAppend, "judges/leetcode/1689");
            Runner.Run(fileLocation, () =>
            {
                int N = int.Parse(Console.ReadLine()!);
                while (N-- > 0)
                {
                    string number = Console.ReadLine();
                    Console.WriteLine(MinPartitions(number));
                }
            });
        }
    }
}
