namespace FDM.interfaces
{
    public interface ICustomerManager
    {
         public bool CreateCustomer(string customerName);
         public void UpdateCustomer( string customerFirstName, string customerLastName);
         public void DeleteCustomer();
         public void GetCustomer(string customerEmail);
    }
}