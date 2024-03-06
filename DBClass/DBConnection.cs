using EntityObject.Entity;
using Microsoft.EntityFrameworkCore;

namespace DBClass
{
    public class DBConnection:DbContext
    {
        public DBConnection(DbContextOptions<DBConnection> options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
            .HasNoKey();
           
        }
        public virtual DbSet<Users> Users { get; set; }


    }
}