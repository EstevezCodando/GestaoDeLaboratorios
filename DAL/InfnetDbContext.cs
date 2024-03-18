using GestaoDeLaboratorios.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaodeLaboratorio.DAL
{
    public class INFNETDbContext : DbContext
    {
        public INFNETDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Computadores> Computadores { get; set; }

    }
}
