using System;

namespace DogApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = null;
            try
            {
                dog = new Dog("Spot", -3);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("error, recovering");
                dog = new Dog("Spot", 5);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("error, recovering");
                dog = new Dog("Spot", 5);
            }
            
        }
    }
}
