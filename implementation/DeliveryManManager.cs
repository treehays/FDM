using FDM.interfaces;
namespace FDM.implementation
{
    public class DeliveryManManager : IDeliveryManManager
    {
        public static List<DeliveryMan> listOfDeliveryMan = new List<DeliveryMan>();
        public void CreateDeliveryMan(string firstName, string lastName, string email, string phoneNumber, int pIN, string bikePlateNumber)
        {
            DeliveryMan deliveryMan = new DeliveryMan(firstName, lastName, email, phoneNumber, pIN, bikePlateNumber);
            
        }

        public void DeleteDeliveryMan(string email)
        {
            foreach (var item in listOfDeliveryMan)
            {
                if (item.Email == email)
                {
                    listOfDeliveryMan.Remove(item);
                    break;
                }
            }
            Console.WriteLine("Delivery Bike Data deleted Successfully..");
        }

        public void GetDeliveryMan(string email)
        {
        }

        public void UpdateDeliveryMan(string firstName, string lastName, string phoneNumber, string bikePlateNumber)
        {
        }
    }

}