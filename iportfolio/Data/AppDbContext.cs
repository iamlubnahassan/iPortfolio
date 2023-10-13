using iportfolio.Model;
using Microsoft.EntityFrameworkCore;

namespace iportfolio.Data
{
    public class AppDbContext :DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        {
            
        }
        // properties to create table in the database
        public DbSet<Contact> tbl_Contact { get; set; }
        public DbSet<Education> tbl_Education { get; set; }
        public DbSet<Experience> tbl_Experience { get; set; }
        public DbSet<Facts> tbl_Fact { get; set; }
        public DbSet<Profoil> tbl_Profoil { get; set; }
        public DbSet<Service> tbl_Service { get; set; }
        public DbSet<Skill> tbl_Skill { get; set; }
        public DbSet<SocialNetwork> tbl_SocailNetwork { get; set; }
        public DbSet<Testimonial> tbl_testimonial { get; set; }
      
    }
}
