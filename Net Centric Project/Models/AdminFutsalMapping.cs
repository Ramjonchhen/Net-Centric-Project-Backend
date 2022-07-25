using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Centric_Project.Models
{
    public class AdminFutsalMapping
    {
        [Key]
        [Column(Order = 1)]
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        [Key]
        [Column(Order = 2)]
        public int FutsalId { get; set; }
        public Futsal Futsal { get; set; }

    }
}
