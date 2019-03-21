using Microsoft.EntityFrameworkCore;

namespace pan2api.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        public DbSet<UserModel> users { get; set; }
    }
}
