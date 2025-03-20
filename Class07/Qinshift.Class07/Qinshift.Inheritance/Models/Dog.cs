using Qinshift.Inheritance.models;

namespace Qinshift.Inheritance.Models
{
    public class Dog : Animal

        
    {

        public Dog(string name, string type, string color, string breed) : base(name, type, color)
        {

            Console.WriteLine("Dog constructor is called");
            Breed = breed;
        }
        // This Dog class will have every property and method that the Animal class has



        // This property will be unique to the Dog class ==>

        public string Breed { get; set; }


        public override void Speak()
        {
            Console.WriteLine($"{Name} the {Color} {Breed} says woof!");
        }

    }
}
