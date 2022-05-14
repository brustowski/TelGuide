using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TelGuide.Guide.Data
{
    public interface IGuideDbContext
    {
        DbSet<Person> Persons { get; set; }
        DbSet<Contact> Contacts { get; set; }
        Task<int> SaveChangesAsync();
    }
}
