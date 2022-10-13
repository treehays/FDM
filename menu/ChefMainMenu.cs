using FDM.implementation;
using FDM.interfaces;
namespace FDM.menu
{
    public class ChefMainMenu
    {
        IChefManager chefManager = new ChefManager();
        public void ChefMenu()
        {

            Console.WriteLine("Enter 1 to Register \nEnter 2  to Login \nEnter 3 to Go Back");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                RegisterChefMenu();

            }
            else if (choice == 2)
            {
                LoginMenu();
            }
            else
            {

            }

        }
        public void RegisterChefMenu()

        {

            Console.Write("Chef First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter PIN: ");
            int pIN = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter post: ");
            //  string post = Console.ReadLine();

            chefManager.CreateChef(firstName, lastName, email, pIN);
            ChefMenu();
        }
        public void LoginMenu()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("PIN: ");
            int pIN = Convert.ToInt32(Console.ReadLine());

            Chef che = chefManager.Login(email, pIN);
            if (che != null)
            {
                Console.WriteLine("Login Successful.");
                ChefSubMenu();
            }
            else
            {
                Console.WriteLine("Wrong email or Pin.");
            }
        }

        public void ChefSubMenu()
        {
            Console.WriteLine("Enter 1 to Add Food \nEnter 2  to Update Food \nEnter 3 to Go Back"); //need modification

        }



    }
}
