namespace FDM
{
    public class DeliveryMan : User
    {
        public string BikePlateNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DeliveryMan (string firstName, string lastName, string email, string phoneNumber,int pIN, string bikePlateNumber) : base(firstName, lastName, email, pIN)
        {
            BikePlateNumber = bikePlateNumber;
            PhoneNumber = phoneNumber;
        }
    }
}