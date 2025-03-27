using AcademyManagement.Services;
namespace AcademyManagement.App.UI
{
    public class UserInterface
    {
        private ValidationService _validationService;
        public bool InitApp()
        {

            WelcomeMenu();
            int choice = _validationService.GetValidOption(new int[] { 1, 2, 3, });











            return false;
        }

        public void WelcomeMenu()
        {
            WriteInColor("Welcome to Academy Management", ConsoleColor.DarkCyan);
            WriteInColor("\nChose your role to login: \n1.Admin \n2.Trainer \n3.Student", ConsoleColor.Cyan);
        }


        public void WriteInColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();

        }
    }
}
