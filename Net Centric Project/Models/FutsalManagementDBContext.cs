using Microsoft.EntityFrameworkCore;

namespace Net_Centric_Project.Models
{
    public class FutsalManagementDBContext: DbContext
    {
        public DbSet<Futsal> Futsals { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<AdminFutsalMapping> AdminFutsalMappings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=FutsalManagementDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminFutsalMapping>()
                .HasKey(c => new { c.AdminId, c.FutsalId });
        }
       
    }
}
