namespace FDM.menu
{
    public class MM
    {
        public void MainMenu()
        {
            Console.WriteLine("Enter 1 for Admin \nEnter 2  for Chef\nEnter 3 for DeliveryMan");
            int opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                AM am = new AM();
                am.AdminMenu();
            }
            else if (opt == 2)
            {
                // Chef
                
            } 
            else if (opt== 3)
            {
                // customer
            } 
            else if (opt == 4)
            {
                //delivery
            }
        }
    }
}