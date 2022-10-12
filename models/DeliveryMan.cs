namespace FDM
{
    public class DeliveryMan : User
    {
        public string BikePlateNumber { get; set; }
        public string DeliveryManPhoneNumber { get; set; }
        public DeliveryMan (string firstName, string lastName, string email, string pIN, string bikePlateNumber, string deliveryManPhoneNumber) : base(firstName, lastName, email, pIN)
        {
            BikePlateNumber = bikePlateNumber;
            DeliveryManPhoneNumber = deliveryManPhoneNumber;

        }
    }
}