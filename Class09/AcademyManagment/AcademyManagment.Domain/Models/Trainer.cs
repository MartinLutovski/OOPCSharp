using AcademyManagment.Domain.Enums;

namespace AcademyManagment.Domain.Models
{
    public class Trainer : User
    {
        public Trainer(string firstName, string lastName, string username, string password, int age) : base(firstName, lastName, age, username, password)
        {
            Role = Enums.Role.Trainer;
        }

        public Trainer(string userName, string password) : base(userName, password)
        {
            Role = Enums.Role.Trainer;
        }


    }
}
