using FDM.interfaces;
using FDM.models;
namespace FDM.interfaces
{
    public interface IChefManager
    {
        public bool CreateOrder(string firstName, string lastName, string email, string pIN, string chefID);
        public void UpdateOrder(string firstName, string lastName);
        public void DeleteOrder(Chef chef);
        public Chef GetOrder(string email);
    }
}