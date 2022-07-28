using System.ComponentModel.DataAnnotations;

namespace Net_Centric_Project.Models
{
    public class Users
    {
        public int UsersId { get; set; }
        public string Name { get; set; }
        [Key]
        public string Email { get; set; }
        public byte[] Salt { get; set; }
        public byte[] Hash { get; set; }
    }
}
