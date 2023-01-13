using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FZIntegradosContext : DbContext
    {
        public FZIntegradosContext(DbContextOptions<FZIntegradosContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // tabla intermedia Diagnostico-Medicamento

            modelBuilder.Entity<Diagnostico>()
                .HasMany(d => d.Medicamentos)
                .WithMany(m => m.Diagnosticos)
                .UsingEntity<DiagnosticoMedicamento>(
                    dm => dm.HasOne(prop => prop.Medicamento)
                    .WithMany()
                    .HasForeignKey(prop => prop.Medicamento_Id),
                    dm => dm.HasOne(prop => prop.Diagnostico)
                    .WithMany()
                    .HasForeignKey(prop => prop.Diagnostico_Id)
                );


            // Diagnóstico

            modelBuilder.Entity<Diagnostico>().HasKey(x => x.Id_Diagnostico);
            modelBuilder.Entity<Diagnostico>().Property(x => x.Id_Diagnostico).HasColumnType("INT");
            modelBuilder.Entity<Diagnostico>().Property(x => x.Detalle).HasColumnType("VARCHAR(100)").IsRequired();

            // Integrado

            modelBuilder.Entity<Integrado>().HasKey(x => x.Id_Integrado);
            modelBuilder.Entity<Integrado>().Property(x => x.Id_Integrado).HasColumnType("INT");
            modelBuilder.Entity<Integrado>().Property(x => x.Cod_Integrado).HasColumnType("VARCHAR(6)").IsRequired();
            modelBuilder.Entity<Integrado>().Property(x => x.Nombre).HasColumnType("VARCHAR(50)").IsRequired();
            modelBuilder.Entity<Integrado>().Property(x => x.Crianza).HasColumnType("INT");
            modelBuilder.Entity<Integrado>().Property(x => x.FechaInicio).HasColumnType("DATE").IsRequired();

            // Medicamento

            modelBuilder.Entity<Medicamento>().HasKey(x => x.Id_Medicamento);
            modelBuilder.Entity<Medicamento>().Property(x => x.Id_Medicamento).HasColumnType("INT");
            modelBuilder.Entity<Medicamento>().Property(x => x.Cod_Producto).HasColumnType("VARCHAR(10)").IsRequired();
            modelBuilder.Entity<Medicamento>().Property(x => x.Nombre).HasColumnType("VARCHAR(50)").IsRequired();

            // Recorredor

            modelBuilder.Entity<Recorredor>().HasKey(x => x.Id_Recorredor);
            modelBuilder.Entity<Recorredor>().Property(x => x.Id_Recorredor).HasColumnType("INT");
            modelBuilder.Entity<Recorredor>().Property(x => x.Nombre).HasColumnType("VARCHAR(50)").IsRequired();
            modelBuilder.Entity<Recorredor>().Property(x => x.Clave).HasColumnType("VARCHAR(20)").IsRequired();

            // RegistroDeRecorredor

            modelBuilder.Entity<RegistroDeRecorredor>().HasKey(x => x.Id_Registro);
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Id_Registro).HasColumnType("INT");
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Fecha).HasColumnType("DATE").IsRequired();
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Hora).HasColumnType("DATE").IsRequired();
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Id_Recorredor).HasColumnType("INT");
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Id_Integrado).HasColumnType("INT");
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Galpon).HasColumnType("VARCHAR(50)").IsRequired();
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Id_Diagnostico).HasColumnType("INT").IsRequired();
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Id_Medicamento).HasColumnType("INT").IsRequired();
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Cantidad_Medicamento).HasColumnType("INT").IsRequired();
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Cantidad_Dias_Tratamiento).HasColumnType("INT").IsRequired();
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Comentario).HasColumnType("VARCHAR(200)").IsRequired();
            modelBuilder.Entity<RegistroDeRecorredor>().Property(x => x.Fecha_Real).HasColumnType("DATE");
            
            

            modelBuilder.Entity<RegistroDeRecorredor>()
                .HasOne(r => r.Recorredor)
                .WithMany()
                .HasForeignKey(r => r.Id_Recorredor);

            modelBuilder.Entity<RegistroDeRecorredor>()
                .HasOne(r => r.Integrado)
                .WithMany()
                .HasForeignKey(r => r.Id_Integrado);

            modelBuilder.Entity<RegistroDeRecorredor>()
                .HasOne(r => r.Diagnostico)
                .WithMany()
                .HasForeignKey(r => r.Id_Diagnostico);

            modelBuilder.Entity<RegistroDeRecorredor>()
                .HasOne(r => r.Medicamento)
                .WithMany()
                .HasForeignKey(r => r.Id_Medicamento);

        }











        public DbSet<Diagnostico> Diagnosticos { get; set; }

public DbSet<Integrado> Integrados { get; set; }

public DbSet<Medicamento> Medicamentos { get; set; }

public DbSet<Recorredor> Recorredores { get; set; }

public DbSet<RegistroDeRecorredor> RegistrosDeRecorredor { get; set; }

public DbSet<DiagnosticoMedicamento> DiagnosticosMedicamentos { get; set; }

}
}
