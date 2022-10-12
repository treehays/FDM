namespace FDM.interfaces
{
    public interface IDeliveryManManager
    {
         
        public bool CreateDeliveryMan(string email);
         public void UpdateDeliveryMan( string firstName, string lastName, string phoneNumber);
         public void DeleteDeliveryMan();
         public void GetDeliveryMan(string email); 
    }
}