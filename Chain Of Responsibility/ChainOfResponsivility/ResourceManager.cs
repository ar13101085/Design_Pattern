namespace TestCSharp.ChainOfResponsivility
{
    public class ResourceManager :IAprove
    {
        public Response Approved(Employee e)
        {
            if (e.Day==3)
            {
                return Response.Accept;
            }

            return Response.Deny;
        }

        public IAprove NextAprover { get; set; }
    }
}