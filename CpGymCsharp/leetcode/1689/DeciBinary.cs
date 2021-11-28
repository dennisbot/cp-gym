using System;
using CpGymCsharp.interfaces;
using CpGymCsharp.utils;

namespace CpGymCsharp.leetcode
{
    public class DeciBinary : IProblem
    {
        internal static readonly IProblem Instance;
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

        public string FileLocation { get; set; } = "leetcode/1689";
        public void Run()
        {
            Runner.Run(FileLocation, () =>
            {
                int N = int.Parse(Console.ReadLine());
                while (N-- > 0)
                {
                    string number = Console.ReadLine();
                    Console.WriteLine(MinPartitions(number));
                }
            });
        }
    }
}
