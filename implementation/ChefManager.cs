using FDM.interfaces;
namespace FDM.implementation
{
    public class ChefManager : IChefManager
    {
        public static List<Chef> listOfChef = new List<Chef>();
        public void CreateChef(string firstName, string lastName, string email, int pIN, int chefID)
        {
            Random random = new Random();
            chefID = random.Next(100, 999);
            Chef chef = new Chef(firstName, lastName, email, pIN, chefID);
            Console.WriteLine("Account created successfully.");

        }

        public void DeleteChef(String email)
        {
            foreach (var item in listOfChef)
            {
                if (item.Email == email)
                {
                    listOfChef.Remove(item);
                    break;
                }
            }
            Console.WriteLine("Chef Data deleted Successfully..");
        }

        public Chef GetChef(string email)
        {
            foreach (var item in listOfChef)
            {
                if (item.Email == email)
                {
                    return item;                    
                }
            }
            return null;
        }

        public void UpdateChef(string firstName, string lastName, string email)
        {
            Chef chef = GetChef(email);
            if (chef !=null)
            {
                chef.FirstName = firstName;
                chef.LastName = lastName;
                Console.WriteLine("Details Updated successfully.");
            } else
            {
                Console.WriteLine("Admin not found.");
            }
        }
    }

}