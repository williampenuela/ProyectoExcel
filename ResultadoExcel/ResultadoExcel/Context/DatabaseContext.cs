using Microsoft.EntityFrameworkCore;
using ResultadoExcel.Models;

namespace ResultadoExcel.Context
{
    public class DatabaseContext : DbContext
    {
        //conexion con la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectiontring = string.Format(@"Data Source=NIX\BIT_DESA;Initial Catalog=William;Integrated Security=True");
            options.UseSqlServer(connectiontring);
        }

        // ENE_Combustible es el nombre de la tabla de la base de datos( ojo: si se cambia no se hace la conexion a la base de datos)
        public DbSet<Combustible>? ENE_Combustible { get; set; }
    }
}
