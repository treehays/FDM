namespace FDM.interfaces
{
    public interface IDeliveryManManager
    {
         
        public bool ICreateDeliveryMan(string email);
         public void IUpdateDeliveryMan( string firstName, string lastName, string phoneNumber);
         public void IDeleteDeliveryMan();
         public void IGetDeliveryMan(string email); 
    }
}