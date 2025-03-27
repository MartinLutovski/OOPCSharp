using System;

namespace AcademyManagment.Domain.Models
{
   public class Student : User
    {
        public string CurrentSubject { get; set; }
        public Dictionary<string, int> SubjectGrade { get; set; }
        public Student(string firstName, string lastName, string username, string password, int age) : base(firstName, lastName, age, username, password)
        {
            Role = Enums.Role.Student;
        }

        public Student(string userName, string password) : base(userName, password)
        {
            Role = Enums.Role.Student;
        }

    }
}
