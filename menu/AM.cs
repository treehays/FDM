namespace FDM.menu
{
    public class AM
    {
        public void AdminMenu()
        {
            Console.WriteLine("Enter 1 to Register Enter 2  to Login \nEnter 3 to Go Back");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                AM am = new AM();
                am.AdminMenu();

            }
            else if (choice == 2)
            {

            } else
            {
                
            }

        }



    }
}