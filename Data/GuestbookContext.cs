using Microsoft.EntityFrameworkCore;
using GuestBook.Models;

namespace GuestBook.Data
{
    public class GuestbookContext : DbContext
    {
        public GuestbookContext (DbContextOptions<GuestbookContext> options)
            : base(options)
        {
        }

        public DbSet<Guest> Guest { get; set; }
    }
}
