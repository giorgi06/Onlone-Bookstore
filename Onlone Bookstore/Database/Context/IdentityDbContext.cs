using Microsoft.EntityFrameworkCore;

namespace Onlone_Bookstore.Database.Context
{
    public class IdentityDbContext<T>
    {
        private DbContextOptions<LibraryContext> options;

        public IdentityDbContext(DbContextOptions<LibraryContext> options)
        {
            this.options = options;
        }
    }
}