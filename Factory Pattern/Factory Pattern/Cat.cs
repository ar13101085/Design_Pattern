using System;
using Factory_Pattern.CreationalInterface;

namespace Factory_Pattern
{
    public class Cat:IAnimalSound
    {
        public void Sound()
        {
            Console.WriteLine("Meao..meaw..meawwwww..........");
        }
    }
}