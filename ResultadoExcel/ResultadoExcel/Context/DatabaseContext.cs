﻿using Microsoft.EntityFrameworkCore;
using ResultadoExcel.Models;

namespace ResultadoExcel.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=NIX\BIT_DESA;Initial Catalog=Bit_V3;Integrated Security=True");
            options.UseSqlServer(connectionString);
        }
        public DbSet<ENE_Combustible>? ENE_Combustible { get; set; }
    }
}