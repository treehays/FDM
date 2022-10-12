using FDM.interfaces;
namespace FDM.implementation
{
    public class AdminManager : IAdminManager
    {
        public static List<Admin> listOfAdmin = new List<Admin>();
        public void CreateAdmin(string firstName, string lastName, string email, int pIN, string post)
        {
            Random random = new Random();
            int adminID = random.Next(100, 999);

            Admin admin = new Admin(firstName, lastName, email, pIN, adminID, post);
            Console.WriteLine($"Dear {lastName}, Your Account created successfully.");


        }

        public void DeleteAdmin(string email)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.Email == email)
                {
                    listOfAdmin.Remove(item);
                    break;
                }
            }
            Console.WriteLine("Data deleted Successfully.");
        }

        public Admin GetAdmin(string email)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.Email == email)
                {
                    return item;
                }

            }
            return null;
        }

        public Admin Login(string email, int pin)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.Email == email && item.PIN == pin)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateAdmin(string firstName, string lastName, string email, string post)
        {
            Admin admin = GetAdmin(email); // y this
            if (admin != null)
            {
                admin.FirstName = firstName;
                admin.LastName = lastName;
                admin.Post = post;
                Console.WriteLine("Details Updated successfully.");
            } else
            {
                Console.WriteLine("Admin not found!");
            }
        }
    }

}