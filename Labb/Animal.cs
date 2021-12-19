using System;

namespace Labb
{
     class Animal
    {
        public string Name { get; set; }
        public int Id { get; set; }


        public string GetName()
        {
            return Name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Make animal sound");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int id) 
        {
            Name = name;
            Id = id;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wooff wooff!!");
        }
       
    }


}