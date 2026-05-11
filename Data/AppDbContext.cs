using Microsoft.EntityFrameworkCore;
using PetroAtivosSeuRA.Models;

namespace PetroAtivosSeuRA.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ativo> Ativos { get; set; }
    }
}