namespace FDM
{
    public class Admin : User
    {
        public string AdminID { get; set; }
        public string Post { get; set; }
        public Admin (string firstName, string lastName, string email, string pIN, string adminID, string post) : base(firstName, lastName, email, pIN)
        {
            AdminID = adminID;
            Post = post;
        }

    }
}
