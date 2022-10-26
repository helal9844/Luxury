using Luxury_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Luxury_Back.DB
{
    public class LuxuryDb: DbContext
    {
        public virtual DbSet<User> users { get; set; }
        public LuxuryDb(DbContextOptions <LuxuryDb> dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
