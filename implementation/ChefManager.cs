using FDM.interfaces;
namespace FDM.implementation
{
    public class ChefManager : IChefManager
    {
        public static List<Chef> listOfChef = new List<Chef>();
        public void CreateChef(string firstName, string lastName, string email, int pIN)
        {
            Random random = new Random();
            int chefID = random.Next(100, 999);
            Chef chef = new Chef(firstName, lastName, email, pIN, chefID);
            listOfChef.Add(chef);
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
            Console.WriteLine("Chef Data permanently deleted ..");
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

        public Chef Login(string email, int pIN)
        {
            foreach (var item in listOfChef)
            {
                if (item.Email == email && item.PIN == pIN)
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