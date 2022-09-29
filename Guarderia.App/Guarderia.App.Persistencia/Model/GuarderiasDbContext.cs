using Guarderia.App.Dominio.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Guarderia.App.Persistencia.Model
{
    public class GuarderiasDbContext : IdentityDbContext 
    {
        public MatriculasDbContext(DbContextOptions<GuarderiasDbContext> options): base(options)
        {

        }

        public virtual DbSet<Estudiante> Alumnos { get; set; }
        public virtual DbSet<TiposIdentificacion> Personas { get; set; }
        public virtual DbSet<Grado> Grados { get; set; }
        public virtual DbSet<Matricula> Guarderias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {       
            modelBuilder.Entity<Grado>()
           .HasData(
               new Grado
               {
                   IdGrado = 1,
                   NombreGrado = "Pre-jardin"
               },
               new Grado
               {
                   IdGrado = 2,
                   NombreGrado = "Jardin"
               }
               ,
               new Grado
               {
                   IdGrado = 3,
                   NombreGrado = "Trancision"
               }
               
           );
                        
            base.OnModelCreating(modelBuilder);
        }
    }
}
