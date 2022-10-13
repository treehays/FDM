namespace FDM.menu
{
    public class MMainMenu
    {
        public void MainMenu()
        {
            Console.WriteLine("Enter 1 for Admin \nEnter 2  for Chef\nEnter 3 for Customers \nEnter 4 for Delivery Bike Man");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                AdminMainMenu adminMainMenu = new AdminMainMenu();
                adminMainMenu.AdminMenu();
            }
            else if (opt == 2)
            {
                ChefMainMenu chefMainMenu = new ChefMainMenu();
                chefMainMenu.ChefMenu();

            }
            else if (opt == 3)
            {
                CustomerMainMenu customerMainMenu = new CustomerMainMenu();
                customerMainMenu.CustomerMenu();
            }
            else if (opt == 4)
            {
                DeliveryManMainMenu deliveryManMainMenu = new DeliveryManMainMenu();
                deliveryManMainMenu.DeliveryManMenu();
            }
            else
            {
                
            }
        }
        
    }
}