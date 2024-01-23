using Microsoft.EntityFrameworkCore;

namespace WebSpasial.EfCore
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> option): base(option) { }
        public DbSet<Tempat> tempats { get; set; }
    }
}
