using System;

namespace Singleton
{
    public sealed class SingletonImageViewer //sealed means inherited class can't call parrent constructor multiple time
    {
        private static int count = 0;
        private static SingletonImageViewer Instance { get; set; }
        private static Object obj=new object();
        
        public static SingletonImageViewer GetInstance
        {
            get
            {
                //Single ton with thread save implementation
                if (Instance == null) //implement double lock checking for lock optimization checking
                {
                    lock (obj)
                    {
                        if (Instance == null)
                        {
                            Instance=new SingletonImageViewer();
                        }
                    }
                }
                

                return Instance;

            }
        }

        private SingletonImageViewer()
        {
            Console.WriteLine("contructor call");
            Console.WriteLine(++count+"");
        }
    }
}