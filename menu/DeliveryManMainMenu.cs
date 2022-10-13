using FDM.implementation;
using FDM.interfaces;
namespace FDM.menu
{
    public class DeliveryManMainMenu
    {
        IDeliveryManManager deliveryManManager = new DeliveryManManager();
        public void DeliveryManMenu()
        {
            Console.WriteLine("Enter 1 to Register \nEnter 2  to Login \nEnter 3 to Go Back");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                RegisterDeliveryManMenu();

            }
            else if (choice == 2)
            {
                LoginMenu();
            }
            else
            {

            }

        }
        public void RegisterDeliveryManMenu()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter PIN: ");
            int pIN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Chef First Name: ");
            string bikePlateNumber = Console.ReadLine();

            deliveryManManager.CreateDeliveryMan(firstName, lastName, email,phoneNumber, pIN, bikePlateNumber);
            DeliveryManMenu();
        }
        public void LoginMenu()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("PIN: ");
            int pIN = Convert.ToInt32(Console.ReadLine());

            DeliveryMan deliveryMan = deliveryManManager.Login(email, pIN);
            if (deliveryMan != null)
            {
                Console.WriteLine("Login Successful.");
                DeliveryManSubMenu();
            }
            else
            {
                Console.WriteLine("Wrong email or Pin.");
            }
        }

        public void DeliveryManSubMenu()
        {
            Console.WriteLine("Enter 1 to Add Food \nEnter 2  to Update Food \nEnter 3 to Go Back"); //need modification

        }



    }
}
