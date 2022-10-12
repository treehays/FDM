namespace FDM
{
    public class Admin : User
    {
        public string AdminID { get; set; }
        public string adminEmploymentDate { get; set; }
        public Admin (string firstName, string lastName, string email, string pIN, string adminID, string adminEmploymentDate) : base(firstName, lastName, email, pIN)
        {
            AdminID = adminID;
            adminEmploymentDate = adminEmploymentDate;
        }

    }
}