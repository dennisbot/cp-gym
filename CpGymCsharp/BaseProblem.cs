using System;
using System.IO;
using static CpGymCsharp.utils.Constants;

namespace CpGymCsharp
{
    public class BaseProblem
    {
        public virtual void Run(string fileLocation = "uva/10018")
        {
#if DENNISBOT
            StreamReader streamReader = new StreamReader(Path.Combine(SolutionDir, fileLocation, "in.in"));
            StreamWriter streamWriter =
                new StreamWriter(Path.Combine(SolutionDir, fileLocation, "ou.out")) {AutoFlush = true};
            Console.SetIn(streamReader);
            Console.SetOut(streamWriter);
            Console.SetError(streamWriter);
#endif
        }
    }
}
