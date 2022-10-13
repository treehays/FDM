namespace FDM.interfaces
{
    public interface ICustomerManager
    {
        public void CreateCustomer(string firstName, string lastName, string email, int pIN, string customerAddress, string phoneNumber, int customerID);
        public void UpdateCustomer(string firstName, string lastName, string customerAddress);
        public void DeleteCustomer();
        public void GetCustomer(string customerEmail);
    }
}