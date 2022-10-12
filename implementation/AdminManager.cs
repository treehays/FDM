using FDM.interfaces;
namespace FDM.implementation
{
    public class AdminManager : IAdminManager
    {
        public static List<Admin> listOfAdmin = new List<Admin>();
        public bool CreateAdmin(string firstName, string lastName, string email, string post, string adminID)
        {
            Random random = new Random();
            int adminID = random.Next(100, 999)
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

        public void UpdateAdmin(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }

}