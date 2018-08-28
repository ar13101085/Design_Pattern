using System;
using Factory_Pattern.CreationalInterface;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalSoundFactory animalSoundFactory=new AnimalSoundFactory();

            IAnimalSound animalSound1 = animalSoundFactory.GetAnimalSound("DOG");
            IAnimalSound animalSound2 = animalSoundFactory.GetAnimalSound("CAT");
            animalSound2.Sound();
            animalSound1.Sound();
        }
    }
}