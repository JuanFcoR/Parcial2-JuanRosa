using Parcial2_JuanRosa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Parcial2_JuanRosa.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
