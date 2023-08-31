﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parcial.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RC101320Entities1 : DbContext
    {
        public RC101320Entities1()
            : base("name=RC101320Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<InscripcionMateria> InscripcionMaterias { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int InsertarUsuario(string nuevoUsuario, string nuevaContraseña)
        {
            var nuevoUsuarioParameter = nuevoUsuario != null ?
                new ObjectParameter("NuevoUsuario", nuevoUsuario) :
                new ObjectParameter("NuevoUsuario", typeof(string));
    
            var nuevaContraseñaParameter = nuevaContraseña != null ?
                new ObjectParameter("NuevaContraseña", nuevaContraseña) :
                new ObjectParameter("NuevaContraseña", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarUsuario", nuevoUsuarioParameter, nuevaContraseñaParameter);
        }
    
        public virtual ObjectResult<ObtenerCarreras_Result> ObtenerCarreras()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerCarreras_Result>("ObtenerCarreras");
        }
    }
}
