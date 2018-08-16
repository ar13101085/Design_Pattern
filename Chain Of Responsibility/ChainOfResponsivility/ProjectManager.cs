namespace TestCSharp.ChainOfResponsivility
{
    public class ProjectManager :IAprove
    {
        public Response Approved(Employee e)
        {
            if (e.Day==2)
            {
                return Response.Accept;
            }

            return NextAprover.Approved(e);
        }

        public IAprove NextAprover { get; set; }
    }
}