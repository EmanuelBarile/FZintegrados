using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FZIntegradosContext : DbContext
    {
        public FZIntegradosContext(DbContextOptions<FZIntegradosContext> options) : base(options) { }

        public DbSet<Diagnostico> Diagnosticos { get; set; }

        public DbSet<Integrado> Integrados { get; set; }

        public DbSet<Medicamento> Medicamentos { get; set; }

        public DbSet<Recorredor> Recorredores { get; set; }

        public DbSet<RegistroDeRecorredor> Registros { get; set; }

    }
}
