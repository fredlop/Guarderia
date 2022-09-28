using MatriculaOnline.App.Dominio.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace MatriculaOnline.App.Persistencia.Model
{
    public class MatriculasDbContext : IdentityDbContext 
    {
        public MatriculasDbContext(DbContextOptions<MatriculasDbContext> options): base(options)
        {

        }

        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<TiposIdentificacion> TiposDeIdentificacion { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Year> Years { get; set; }
        public virtual DbSet<Profesor> Profesores { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<Grado> Grados { get; set; }
        public virtual DbSet<Matricula> Matriculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Year>()
                .HasData(
                    new Year
                    {
                        IdYear = 1,
                        NombreYear = "2022"
                    },
                    new Year
                    {
                        IdYear = 2,
                        NombreYear = "2023"
                    }
                );

            modelBuilder.Entity<Grado>()
           .HasData(
               new Grado
               {
                   IdGrado = 1,
                   NombreGrado = "Primero de primaria"
               },
               new Grado
               {
                   IdGrado = 2,
                   NombreGrado = "Segundo de de primaria"
               }
               ,
               new Grado
               {
                   IdGrado = 3,
                   NombreGrado = "Tercero de de primaria"
               }
               ,
               new Grado
               {
                   IdGrado = 4,
                   NombreGrado = "Cuarto de de primaria"
               }               ,
               new Grado
               {
                   IdGrado = 5,
                   NombreGrado = "Quinto de de primaria"
               }
           );
            modelBuilder.Entity<TiposIdentificacion>()
                .HasData(
                    new TiposIdentificacion
                    {
                        IdIdentificacion = 1,
                        NombreIdentificacion = "Tarjeta de Identidad"
                    },
                    new TiposIdentificacion
                    {
                        IdIdentificacion = 2,
                        NombreIdentificacion = "Cedula"
                    },
                    new TiposIdentificacion
                    {
                        IdIdentificacion = 3,
                        NombreIdentificacion = "Pasaporte"
                    },
                    new TiposIdentificacion
                    {
                        IdIdentificacion = 4,
                        NombreIdentificacion = "Cedula de extranjeria"
                    }
                );

            modelBuilder.Entity<Genero>()
               .HasData(
                   new Genero
                   {
                       IdGenero = 1,
                       NombreGenero = "Masculino"
                   },
                   new Genero
                   {
                       IdGenero = 2,
                       NombreGenero = "Femenino"
                   }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
}
