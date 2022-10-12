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

            Admin admin = new Admin(firstName,lastName,email,pIN,post);


        }

        public void DeleteAdmin(Admin email)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.Email == email)
                {
                    listOfAdmin.Remove(item);
                    break;

                }

            }
        }

        public Admin GetAdmin(string email)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.Email == email)
                {

                }

            }
        }

        public Admin Login(string email, int pin)
        {
            foreach (var item in listOfAdmin)
            {
                if (item.Email == email && item.PIN == pin)
                {
                    return 
                }
            }
        }

        public void UpdateAdmin(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }

}