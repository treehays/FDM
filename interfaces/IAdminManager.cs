using FDM.models;
namespace FDM.interfaces
{
    public interface IAdminManager
    {
        public bool ICreateAdmin(string email);
         public void IUpdateAdmin( string firstName, string lastName);
         public void IDeleteAdmin();
         public void IGetAdmin(string email);       
         
    }
}