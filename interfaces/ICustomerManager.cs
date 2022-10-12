namespace FDM.interfaces
{
    public interface ICustomerManager
    {
         public bool ICreateCustomer(string customerName);
         public void IUpdateCustomer( string customerFirstName, string customerLastName);
         public void IDeleteCustomer();
         public void IGetCustomer(string customerEmail);
    }
}