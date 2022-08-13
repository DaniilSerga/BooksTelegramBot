using Microsoft.EntityFrameworkCore;
using Bot.Model.Models;

namespace Bot.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }
    }
}