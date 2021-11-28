﻿using System;

namespace CpGymCsharp.uva
{
    public class ReverseAndAdd : BaseProblem
    {
        static string Solve(uint number)
        {
            int iteration = 0;
            do
            {
                string reverse = "";
                string numAsString = number.ToString();
                int numLen = numAsString.Length;
                for (int i = 0; i < numLen; i++)
                {
                    reverse += numAsString[numLen - i - 1];
                }

                number = number + uint.Parse(reverse);
                iteration++;
            } while (!IsPalindrome(number));

            return $"{iteration} {number}";
        }

        private static bool IsPalindrome(uint number)
        {
            string numAsString = number.ToString();
            int len = numAsString.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (numAsString[i] != numAsString[len - i - 1])
                    return false;
            }

            return true;
        }

        public override void Run(string fileLocation = "uva/10018")
        {
            base.Run(fileLocation);
            int N = int.Parse(Console.ReadLine());
            while (N-- > 0)
            {
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine(Solve(number));
            }
        }
    }
}