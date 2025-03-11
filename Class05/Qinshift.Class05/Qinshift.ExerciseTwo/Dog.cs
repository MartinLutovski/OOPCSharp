namespace Qinshift.ExerciseTwo
{
    public class Dog
    {

        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public string DogEat()
        {
            return $"{Name} is eating.";
        }

        public string Play()
        {
            return $"Name: {Name}, Breed: {Breed}, Color: {Color}";
        }

        public string ChaseTail()
        {
            return $"{Name} is chasing its tail.";
        }
    } 
}