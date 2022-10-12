using FDM.interfaces;
using FDM.models;
namespace FDM.interfaces
{
    public interface IChefManager
    {
        public void CreateChef(string firstName, string lastName, string email, int pIN, int chefID);
        public void UpdateChef(string firstName, string lastName, string email);
        public void DeleteChef(String email);
        public Chef GetChef(string email);
    }
}