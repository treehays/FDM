namespace FDM
{
    public class Customer : User
    {
        // public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int CustomerID { get; set; }
        public string CustomerAddress { get; set; }
        // public double Wallet { get; set; }
        public Customer(string firstName, string lastName, string email, int pIN, string customerAddress, string phoneNumber, int customerID) : base(firstName, lastName, email, pIN)
        {
            CustomerID = customerID;
            PhoneNumber = phoneNumber;
            CustomerAddress = customerAddress;
        }
        

    }
}