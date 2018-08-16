namespace TestCSharp.ChainOfResponsivility
{
    public class TeamLead :IAprove
    {
        public Response Approved(Employee e)
        {
            if (e.Day==1)
            {
                return Response.Accept;
            }

            return NextAprover.Approved(e);
        }

        public IAprove NextAprover { get; set; }
    }
}