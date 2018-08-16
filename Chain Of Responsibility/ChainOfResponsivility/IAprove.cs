namespace TestCSharp.ChainOfResponsivility
{
    public interface IAprove
    {
        Response Approved(Employee e);
        IAprove NextAprover { get; set; }

    }
}