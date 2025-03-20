
namespace Qinshift.Inheritance.models
{
   public class Animal
    {
        public Animal()
        {

        }

        public Animal(string name, string type, string color)
        {
            Console.WriteLine("Animal constructor is called");
            Name = name;
            Type = type;
            Color = color;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }


        public virtual void Speak()
        {
            Console.WriteLine($"Animal {Name} says hi!");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} | Type: {Type} | Color: {Color}");

        }
    }
}
