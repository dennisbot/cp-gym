using System;
using System.IO;
using System.Linq;

namespace CpGymCsharp
{
    class Prob_10018
    {
        static void Main()
        {
            #if DENNISBOT
                TextReader sourceFileReader = new StreamReader(@"../../../in.in");
                Console.SetIn(sourceFileReader);
            #endif
            int N = int.Parse(Console.ReadLine());
            while (N-- > 0)
            {
                int iteration = 0;
                uint number = uint.Parse(Console.ReadLine());
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

                Console.WriteLine($"{iteration} {number}");
            }
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
    }
}