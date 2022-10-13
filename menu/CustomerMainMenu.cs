using FDM.implementation;
using FDM.interfaces;
namespace FDM.menu
{
    public class CustomerMainMenu
    {
        ICustomerManager customerManager = new CustomerManager();
        public void CustomerMenu()
        {
            Console.WriteLine("Enter 1 to Register \nEnter 2  to Login \nEnter 3 to Go Back");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                RegisterCustomerMenu();

            }
            else if (choice == 2)
            {
                LoginMenu();
            }
            else
            {

            }

        }
        public void RegisterCustomerMenu()
        {
            Console.Write("Customer First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter PIN: ");
            int pIN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter address: ");
            string customerAddress = Console.ReadLine();
            Console.Write("Enter phoneNumber: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter customerID: ");
            int customerID = int.Parse(Console.ReadLine());
            

            

            customerManager.CreateCustomer(firstName, lastName, email, pIN, customerAddress,phoneNumber,customerID);
            CustomerMenu();
        }
        public void LoginMenu()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("PIN: ");
            int pIN = Convert.ToInt32(Console.ReadLine());

            Customer cus= customerManager.Login(email, pIN);
            if (cus != null)
            {
                Console.WriteLine("Login Successful.");
                CustomerSubMenu();
            }
            else
            {
                Console.WriteLine("Wrong email or Pin.");
            }
        }

        public void CustomerSubMenu ()
        {
            Console.WriteLine("Enter 1 to Add Food \nEnter 2  to Update Food \nEnter 3 to Go Back"); //need modification
            
        }



    }
}
