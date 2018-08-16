using System;
using System.Globalization;
using TestCSharp.ChainOfResponsivility;

namespace TestCSharp
{
    class Program
    {
        public static IAprove CreateChain()
        {
            IAprove handler=new RequestHandler();
            TeamLead hirarchy1=new TeamLead();
            ProjectManager hirarchy2=new ProjectManager();
            ResourceManager hirarchy3=new ResourceManager();
            handler.NextAprover = hirarchy1;
            hirarchy1.NextAprover = hirarchy2;
            hirarchy2.NextAprover = hirarchy3;
            return handler;
        }
        
        
        
        static void Main(string[] args)
        {
            /*DateTime t1=DateTime.Parse("12/12/2012 12:00 AM");
            DateTime t2=DateTime.Parse("12/12/2012 12:00 PM");
            Console.WriteLine((t2 - t1).Hours);
            Console.WriteLine(t1.Add(TimeSpan.FromHours(24)).Subtract(TimeSpan.FromSeconds(1)).ToString("F"));*/
            
            Employee employee=new Employee();
            employee.Day = 2;
            IAprove handler = CreateChain();
            Response response = handler.Approved(employee);
            if (response == Response.Accept)
            {
                Console.WriteLine("Requested accepted");
            }
            else
            {
                Console.WriteLine("Requested Declined");
            }

        }
    }
}