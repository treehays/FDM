using FDM.implementation;
using FDM.interfaces;
namespace FDM.menu
{
    public class AdminMainMenu
    {
        IAdminManager adminManager = new AdminManager();
        public void AdminMenu()
        {
            Console.WriteLine("Enter 1 to Register \nEnter 2  to Login \nEnter 3 to Go to Main Menu");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 5)
            {
                if (choice == 1)
                {
                    RegisterAdminMenu();

                }
                else if (choice == 2)
                {
                    LoginMenu();
                }
                else if (choice == 3)
                {

                }

            }

        }
        public void RegisterAdminMenu()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter PIN: ");
            int pIN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter post: ");
            string post = Console.ReadLine();

            adminManager.CreateAdmin(firstName, lastName, email, pIN, post);
            AdminMenu();
        }
        public void LoginMenu()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("PIN: ");
            int pIN = Convert.ToInt32(Console.ReadLine());

            Admin admin = adminManager.Login(email, pIN);
            if (admin != null)
            {
                Console.WriteLine("Login Successful.");
                AdminSubMenu();
            }
            else
            {
                Console.WriteLine("Wrong email or Pin.");
            }
        }

        public void AdminSubMenu()
        {
            Console.WriteLine("Enter 1 to Add Food \nEnter 2  to Update Food \nEnter 3 to Go Back"); //need modification

        }



    }
}