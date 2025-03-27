using AcademyManagment.Domain.Enums;
namespace AcademyManagment.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }

        public User(string firstName, string lastName, string username, string password, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
        }

        public User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
