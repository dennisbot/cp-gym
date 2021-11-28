namespace CpGymCsharp.interfaces
{
    public interface IProblem
    {
        string FileLocation { get; set; }
        void Run();
    }
}
