namespace FDM.interfaces
{
    public interface ICustomerManager
    {
        public void CreateCustomer(string firstName, string lastName, string email, int pIN, string customerAddress, string phoneNumber, int customerID);
        public void UpdateCustomer(string firstName, string lastName, string email, string customerAddress);
        public void DeleteCustomer(string email);
        public Customer GetCustomer(string email);
        public Customer Login(string email, int pIN);
    }
}