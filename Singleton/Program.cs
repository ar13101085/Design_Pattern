using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonImageViewer imageViewer1=SingletonImageViewer.GetInstance;
            SingletonImageViewer imageViewer2=SingletonImageViewer.GetInstance;
            
          //  Console.ReadKey();
        }
    }
}