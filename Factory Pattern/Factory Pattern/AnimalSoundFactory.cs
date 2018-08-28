using Factory_Pattern.CreationalInterface;

namespace Factory_Pattern
{
    public class AnimalSoundFactory
    {
        public IAnimalSound GetAnimalSound(string type)
        {
            if (type == "CAT")
            {
                return new Cat();
            }else if (type == "DOG")
            {
                return new Dog();
            }
            return null;
        }
    }
}