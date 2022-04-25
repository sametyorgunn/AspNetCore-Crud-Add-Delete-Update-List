using Microsoft.EntityFrameworkCore;

namespace Library_Registiration.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EHVPQGR;Initial Catalog=Library_system;Integrated Security=True;Pooling=False");
        }

        public DbSet<Author> authors { get; set; }
        public DbSet<Book>books { get; set; }
        public DbSet<Publisher> publishers { get; set; }
    }
}
