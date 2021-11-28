using CpGymCsharp.interfaces;
using CpGymCsharp.uva;

namespace CpGymCsharp
{
    static class Program
    {
        static void Main()
        {
            IProblem problem = ReverseAndAdd.Instance;
            problem.Run();
        }
    }
}
