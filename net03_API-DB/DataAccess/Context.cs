using Microsoft.EntityFrameworkCore;
using net03_API_DB.Models;

namespace net03_API_DB.DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
