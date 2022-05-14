using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TelGuide.Guide.Data
{
    public class GuideDbContext : DbContext, IGuideDbContext
    {

        public GuideDbContext(DbContextOptions<GuideDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
