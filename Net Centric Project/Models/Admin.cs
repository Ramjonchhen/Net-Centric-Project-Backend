using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Centric_Project.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        [Key]
        public string Email { get; set; }
        public byte[] Salt { get; set; }

        public byte[] Hash { get; set; }
    }
}
