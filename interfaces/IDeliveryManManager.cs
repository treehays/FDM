namespace FDM.interfaces
{
    public interface IDeliveryManManager
    {

        public void CreateDeliveryMan(string firstName, string lastName, string email, string phoneNumber,int pIN, string bikePlateNumber);
        public void UpdateDeliveryMan(string firstName, string lastName, string phoneNumber, string bikePlateNumber);
        public void DeleteDeliveryMan();
        public void GetDeliveryMan(string email);
    }
}