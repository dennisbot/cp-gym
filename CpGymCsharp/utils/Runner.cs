using System;
using System.IO;
using static CpGymCsharp.utils.Constants;

namespace CpGymCsharp.utils
{
    public static class Runner
    {
        public static void Run(string fileLocation, Action action)
        {
            if (fileLocation is null)
                throw new ArgumentNullException(nameof(fileLocation));
#if DENNISBOT
            StreamReader streamReader = new StreamReader(Path.Combine(SolutionDir, fileLocation, "in.in"));
            StreamWriter streamWriter =
                new StreamWriter(Path.Combine(SolutionDir, fileLocation, "ou.out")) {AutoFlush = true};
            Console.SetIn(streamReader);
            Console.SetOut(streamWriter);
            Console.SetError(streamWriter);
#endif
            action();
        }
    }
}
