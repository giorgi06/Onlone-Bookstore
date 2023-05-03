using Microsoft.EntityFrameworkCore;
using Onlone_Bookstore.Database.Entities;
using Onlone_Bookstore.Model;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using static Onlone_Bookstore.Database.Entities.book;

namespace Onlone_Bookstore.Database.Context
{
    public class LibraryContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public LibraryContext(DbContextOptions<LibraryContext> options)  
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        
    }
}
