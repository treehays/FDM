using FDM.interfaces;
namespace FDM.implementation
{
    public class DeliveryManManager : IDeliveryManManager
    {
        public static List<DeliveryMan> listOfDeliveryMan = new List<DeliveryMan>();
        public void CreateDeliveryMan(string firstName, string lastName, string email, string phoneNumber, int pIN, string bikePlateNumber)
        {
            DeliveryMan deliveryMan = new DeliveryMan(firstName, lastName, email, phoneNumber, pIN, bikePlateNumber);
            listOfDeliveryMan.Add(deliveryMan);
            Console.WriteLine("Account successfully created.");
            
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

        public DeliveryMan GetDeliveryMan(string bikePlateNumber)
        {
            foreach (var item in listOfDeliveryMan)
            {
                if (item.BikePlateNumber == bikePlateNumber)
                {
                    return item;
                }
            }
            return null;
        }

        public DeliveryMan Login(string email, int pIN)
        {
            foreach (var item in listOfDeliveryMan)
            {
                if (item.Email == email && item.PIN == pIN)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateDeliveryMan(string firstName, string lastName, string phoneNumber, string bikePlateNumber)
        {
            DeliveryMan deliveryMan = GetDeliveryMan(bikePlateNumber);
            if (deliveryMan !=null)
            {
                deliveryMan.FirstName = firstName;
                deliveryMan.LastName = lastName;
                Console.WriteLine("Details Updated successfully.");
            } else
            {
                Console.WriteLine("Admin not found.");
            }
        }
    }

}