using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb
{
    class Shelter
    {

        private readonly List<Animal> _animals = new List<Animal>()
        {
        };

        public void AddAnimal(Animal dog)
        {
            _animals.Add(dog);
            Console.WriteLine(dog.Name + " added");
        }

        public void DeleteAnimal(string name)
        {
            if (_animals[0].Name == name)
            {
                _animals.RemoveAt(0);
            }
            else if (_animals[1].Name == name)
            {
                _animals.RemoveAt(1);
            }
            else
            {
                Console.WriteLine("No more animals to delete");
            }

        }

        public Animal GetAnimal(int id)
        {
            var animal = _animals.Where(item => item.Id == id);
            return animal.SingleOrDefault();
        }

        public void UpdateAnimal(Animal dog, string name)
        {
            var updatedAnimal = _animals.Find(e => e.Name == dog.Name);
            dog.Name = name;
        }

        public List<Animal> GetAnimals()
        {
            return _animals;
        }

        public void DeleteAnimal(int id)
        {
            Animal markedAnimal = _animals.Find(e => e.Id == id);
            _animals.Remove(markedAnimal);
        }

    }
}
