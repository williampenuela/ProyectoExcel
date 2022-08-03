using Microsoft.EntityFrameworkCore;
using ResultadoExcel.Models;

namespace ResultadoExcel.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=NIX\BIT_DESA;Initial Catalog=William;Integrated Security=True");
            options.UseSqlServer(connectionString);
        }
        public DbSet<Combustible>? ENE_Combustible { get; set; }
    }
}
