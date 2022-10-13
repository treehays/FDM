using FDM.interfaces;
namespace FDM.implementation
{
    public class CustomerManager : ICustomerManager
    {
        public static List<Customer> listOfCustomer = new List<Customer>();
        public void CreateCustomer(string firstName, string lastName, string email, int pIN, string customerAddress, string phoneNumber, int customerID)
        {
            Random random = new Random();
            customerID = random.Next(100, 999);
            Customer customer = new Customer(firstName, lastName, email, pIN, customerAddress, phoneNumber, customerID);
            listOfCustomer.Add(customer);
            Console.WriteLine("Account created successfully.");

        }

        public void DeleteCustomer(string email)
        {
            foreach (var item in listOfCustomer)
            {
                if (item.Email == email)
                {
                    listOfCustomer.Remove(item);
                    break;
                }
            }
            Console.WriteLine("Customer Data deleted Successfully..");
        }

        public Customer GetCustomer(string email)
        {
            foreach (var item in listOfCustomer)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;

        }

        public Customer Login(string email, int pIN)
        {
            foreach (var item in listOfCustomer)
            {
                if (item.Email == email && item.PIN == pIN)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateCustomer(string firstName, string lastName, string email, string address)
        {
            Customer customer = GetCustomer(email);
            if (customer != null)
            {
                customer.FirstName = firstName;
                customer.LastName = lastName;
                Console.WriteLine("Details Updated successfully.");
            }
            else
            {
                Console.WriteLine("Admin not found.");
            }
        }
    }

}