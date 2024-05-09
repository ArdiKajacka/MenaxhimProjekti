using MenaxhimProjekti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MenaxhimProjekti.NewFolder
{
    public class AppDbContext:DbContext
    {
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Users> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

    }
}
