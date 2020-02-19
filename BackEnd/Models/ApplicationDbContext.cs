using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    public class ApplicationDbContext : DbContext
    {
        ///<summary>
        /// This is the connection object for our database
        ///</summary>

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Worker> Workers { get; set; }
    }
}