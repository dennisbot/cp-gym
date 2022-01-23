using System;
using CpGymCsharp.interfaces;
using CpGymCsharp.utils;
using Newtonsoft.Json;

namespace CpGymCsharp.judges.codeforces
{
    public class Spiderman : IBaseProblem
    {
        internal static readonly IBaseProblem Instance;
        private Spiderman() {}
        static Spiderman()
        {
            Instance = new Spiderman();
        }

        public static bool PossibleNewLove(string fullname)
        {
            var aFullname = fullname.Split(" ");
#if LOG
            string json = JsonConvert.SerializeObject(aFullname);
            Console.WriteLine(json);
#endif
            char firstNameFirstChar = aFullname[0][0];
            char lastNameFirstChar = aFullname[1][0];
            bool ans = firstNameFirstChar == 'M' && lastNameFirstChar == 'J';
#if LOG
            Console.WriteLine(ans);
#endif
            return ans;
        }

        public void Run(string pathToAppend)
        {
            string fileLocation = Helper.PathCombine(pathToAppend, "judges/codeforces/365620C");
            Runner.Run(fileLocation, () =>
            {
                int N = int.Parse(Console.ReadLine()!);
                int times = 0;
                while (N-- > 0)
                {
                    string fullname = Console.ReadLine();
#if LOG
                    Console.WriteLine(fullname);
#endif
                    times += PossibleNewLove(fullname) ? 1 : 0;
                }
                Console.WriteLine(times);
            });
        }
    }
}
