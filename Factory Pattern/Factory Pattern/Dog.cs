using System;
using Factory_Pattern.CreationalInterface;

namespace Factory_Pattern
{
    public class Dog:IAnimalSound
    {
        public void Sound()
        {
            Console.WriteLine("ghew..ghew..gheeeeew ghewwww");
        }
    }
}