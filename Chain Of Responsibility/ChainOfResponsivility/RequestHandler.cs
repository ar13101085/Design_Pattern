namespace TestCSharp.ChainOfResponsivility
{
    public class RequestHandler : IAprove
    {
        public Response Approved(Employee e)
        {
            return NextAprover.Approved(e);
        }

        public IAprove NextAprover { get; set; }
    }
}