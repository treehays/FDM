using FDM.models;
namespace FDM.interfaces
{
    public interface IAdminManager
    {
        public bool CreateAdmin(string firstName, string lastName, string email, string post, string adminID);
         public void UpdateAdmin( string firstName, string lastName);
         public void DeleteAdmin(Admin admin);
         public Admin GetAdmin(string email);       
         
    }
}