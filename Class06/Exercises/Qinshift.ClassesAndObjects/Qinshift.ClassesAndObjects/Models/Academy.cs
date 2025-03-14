
namespace Qinshift.ClassesAndObjects.Models
{
    public class Academy
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Academy(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
