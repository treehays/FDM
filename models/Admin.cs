namespace FDM
{
    public class Admin : User
    {
        public int AdminID { get; set; }
        public string Post { get; set; }
        public Admin (string firstName, string lastName, string email, int pIN, int adminID, string post) : base(firstName, lastName, email, pIN)
        {
            AdminID = adminID;
            Post = post;
        }

    }
}
