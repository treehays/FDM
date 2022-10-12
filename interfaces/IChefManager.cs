using FDM.models;
namespace FDM.interfaces
{
    public interface IChefManager
    {

        public bool ICreateChef(string email);
        public void IUpdateChef(string firstName, string lastName);
        public void IDeleteChef();
        public void IGetChef(string email);

    }
}