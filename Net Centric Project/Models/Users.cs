namespace Net_Centric_Project.Models
{
    public class Users
    {
        public int UsersId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
    }
}
