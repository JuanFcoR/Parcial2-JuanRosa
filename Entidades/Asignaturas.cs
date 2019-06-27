using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanRosa.Entidades
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Descripcion { get; set; }
        public int Creditos { get; set; }

        public Asignaturas()
        {
            AsignaturaId = 0;
            Descripcion = string.Empty;
            Creditos = 0;
        }

        public Asignaturas(int asignaturaId, string descripcion, int creditos)
        {
            AsignaturaId = asignaturaId;
            Descripcion = descripcion;
            Creditos = creditos;
        }
    }
}
