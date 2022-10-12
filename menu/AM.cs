using FDM.implementation;
using FDM.interfaces;
namespace FDM.menu
{
    public class AM
    {
        IAdminManager adminManager = new AdminManager();
        public void AdminMenu()
        {
            Console.WriteLine("Enter 1 to Register \nEnter 2  to Login \nEnter 3 to Go Back");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                RegisterAdminMenu();

            }
            else if (choice == 2)
            {
            }
            else
            {

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

            Admin ad = adminManager.Login(email, pIN);
            if (ad != null)
            {
                Console.WriteLine("Login Successful.");
                AdminSubMenu();
            }
            else
            {
                Console.WriteLine("Wrong email or Pin.");
            }
        }

        public void AdminSubMenu ()
        {
            Console.WriteLine("Enter 1 to Add Food \nEnter 2  to Update Food \nEnter 3 to Go Back"); //need modification
            
        }



    }
}