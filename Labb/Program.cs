using System;

namespace Labb
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal dog = new Dog("Dog-1", 1); // Ett nytt Dog-objekt skapas
            Animal dog2 = new Dog("Dog-2", 2); // Ett nytt Dog-objekt skapas
            Shelter shelter = new Shelter(); // Ett nytt Shelter-objekt skapas
            shelter.AddAnimal(dog); 
            shelter.AddAnimal(dog2);
            shelter.DeleteAnimal("Dog-1"); 
            shelter.DeleteAnimal(2);
            shelter.AddAnimal(dog);
            shelter.AddAnimal(dog2);
            shelter.UpdateAnimal(dog, "New name");
            Console.WriteLine(shelter.GetAnimal(1).GetName()); // "New name"
            var myshelter = shelter.GetAnimals();

            foreach (Animal animal in myshelter)
            {
                animal.MakeSound(); // "Voff!"
            }

        }
    }
}


