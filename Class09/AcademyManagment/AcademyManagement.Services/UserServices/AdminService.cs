using AcademyManagment.Domain;
using AcademyManagment.Domain.Enums;
using AcademyManagment.Domain.Models;

namespace AcademyManagement.Services.UserServices
{
    public class AdminService
    {

        private DataAccess _dataAccess;
        public AdminService() {
            _dataAccess = new DataAccess();
        }
        // Login
        public Admin AdminLogin(string username, string password)
        {
            Admin adminFromDb = _dataAccess.GetAdmin(username, password);
            if(adminFromDb == null)
            {
               throw new Exception("Invalid credentials entered. Try again.");
            }
            return adminFromDb;

        }

        // CreateUser
        public void CreateUser(string username, string password, Role role)
        {
            bool userExists = _dataAccess.CheckIfUserExists(username, role);
            if (userExists)
            {
                throw new Exception($@"{role} with ""{username}"" already exists!.");
            }
            _dataAccess.CreateNewUser(username, password, role);
        }

        // GetUsersToRemove
        public List<string> GetUsersToRemove(Role role, Admin loggedAdmin)
        {
            return _dataAccess.GetUsernames(role, loggedAdmin);
        }

        // DeleteUser
        public void DeleteUser(string username, Role role)
        {

            bool userExists = _dataAccess.CheckIfUserExists(username, role);
            if (!userExists)
            {
                throw new Exception($@"{role} with ""{username}"" does not exist!.");
            }
            _dataAccess.DeleteUser(username, role);
        }

    }
}
