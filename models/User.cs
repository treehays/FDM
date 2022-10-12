
namespace FDM
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PIN { get; set; }


        public User(string firstName, string lastName, string email, string pIN)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PIN = pIN;

        }




    }
}