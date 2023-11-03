using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TupaERPWeb.Models;

namespace TupaERPWeb.Data
{
    public class TupaERPDbContext :DbContext
    {
        public TupaERPDbContext(DbContextOptions<TupaERPDbContext> options) : base(options) { }


        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Tabela> Tabelas { get; set; }
    }
}
