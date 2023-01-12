﻿using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FZIntegradosContext : DbContext
    {
        public FZIntegradosContext(DbContextOptions<FZIntegradosContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<RegistroDeRecorredor>()
                .HasOne(e => e.Diagnostico)
                .WithOne(e => e.RegistroDeRecorredor)
                .OnDelete(DeleteBehavior.ClientCascade);
        }

        public DbSet<Diagnostico> Diagnosticos { get; set; }

        public DbSet<Integrado> Integrados { get; set; }

        public DbSet<Medicamento> Medicamentos { get; set; }

        public DbSet<Recorredor> Recorredores { get; set; }

        public DbSet<RegistroDeRecorredor> RegistrosDeRecorredor { get; set; }

    }
}
