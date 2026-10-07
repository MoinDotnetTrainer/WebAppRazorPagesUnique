using Microsoft.EntityFrameworkCore;

namespace WebAppRazorPagesUnique.Model
{
    public class Appdb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // parent virtaul is getting implemeted in child
            optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial Catalog=db_webappUnique;Integrated Security=true;TrustServerCertificate=true");
            //   optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial Catalog=db_webappUnique;user id=sa;password=Sa@12345678;TrustServerCertificate=true");
        }

        public DbSet<UsersModel> Users { get; set; }

     public DbSet<DeptModel> Dept { get; set; }
        //Users
        //ORM C# enetity class with db table

        // Code first approach

        // Add & savechanges --> db context
        // Runs Insert & savechages executes that insert query 

    }
}
