using DataAnnotations.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAnnotations.Data
{
    public class DataAnnotationsContext : DbContext
    {
        public DataAnnotationsContext(DbContextOptions<DataAnnotationsContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
