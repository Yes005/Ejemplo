﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plataforma_Estudiantil.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbEstudiantesEntities : DbContext
    {
        public dbEstudiantesEntities()
            : base("name=dbEstudiantesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<alumno> alumnoes { get; set; }
        public virtual DbSet<Alumno_Tarea> Alumno_Tarea { get; set; }
        public virtual DbSet<Asignatura> Asignaturas { get; set; }
        public virtual DbSet<docente> docentes { get; set; }
        public virtual DbSet<grado> gradoes { get; set; }
        public virtual DbSet<Grado_Seccion> Grado_Seccion { get; set; }
        public virtual DbSet<Nota> Notas { get; set; }
        public virtual DbSet<Notas_Periodos> Notas_Periodos { get; set; }
        public virtual DbSet<Periodo> Periodos { get; set; }
        public virtual DbSet<seccion> seccions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tarea> tareas { get; set; }
        public virtual DbSet<tipoUsuario> tipoUsuarios { get; set; }
    }
}