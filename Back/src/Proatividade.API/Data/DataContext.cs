using Microsoft.EntityFrameworkCore;
using Proatividade.API.Models;

namespace Proatividade.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Atividade> Atividades { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}