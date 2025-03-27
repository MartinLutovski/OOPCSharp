namespace AcademyManagment.Domain.Models
{
    public class Admin : User
    {
        public Admin(string firstName, string lastName, string username, string password, int age) : base(firstName, lastName, age, username, password)
        {
            Role = Enums.Role.Admin;
        }         
        public Admin(string userName, string password) : base(userName, password)
        {
            Role = Enums.Role.Admin;
        }

    }
}
