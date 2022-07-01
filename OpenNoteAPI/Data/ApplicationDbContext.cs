using Microsoft.EntityFrameworkCore;

namespace OpenNoteAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
                new Note { Id = 1, Title = "Samle Note 1", Content = "Lorem 1..." },
                new Note { Id = 2, Title = "Samle Note 2", Content = "Lorem 2..." },
                new Note { Id = 3, Title = "Samle Note 3", Content = "Lorem 3..." },
                new Note { Id = 4, Title = "Samle Note 4", Content = "Lorem 4..." }
                );
        }

    }
}
