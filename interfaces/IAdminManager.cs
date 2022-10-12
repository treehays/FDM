using FDM.models;
namespace FDM.interfaces
{
    public interface IAdminManager
    {
        public void CreateAdmin(string firstName, string lastName, string email,  int pIN, string post);
         public void UpdateAdmin( string firstName, string lastName);
         public void DeleteAdmin(Admin admin);
         public Admin GetAdmin(string email);  
         public Admin Login(string email, int pin);
         
    }
}