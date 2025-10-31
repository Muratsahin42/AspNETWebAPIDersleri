using LMS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class LMSDBContext: DbContext
    {
        public DbSet<User>Users{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyLMSDatabase");
        }
    }
}
