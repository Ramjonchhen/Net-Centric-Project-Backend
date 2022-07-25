using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Centric_Project.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }

        public string Hash { get; set; }
    }
}
