
namespace FDM
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PIN { get; set; }


        public User(string firstName, string lastName, string email, int pIN)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PIN = pIN;

        }




    }
}