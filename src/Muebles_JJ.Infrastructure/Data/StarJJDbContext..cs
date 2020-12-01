using Microsoft.EntityFrameworkCore;
using Muebles_JJ.Core.Domain;

namespace Muebles_JJ.Infrastructure.Data
{
    public class STAR_JJDbContext : DbContext
    {
        public STAR_JJDbContext(DbContextOptions<STAR_JJDbContext> options) : base(options)
        {

        }

        public DbSet<ColorProducto> ColorProducto { get; set; }
    }
}