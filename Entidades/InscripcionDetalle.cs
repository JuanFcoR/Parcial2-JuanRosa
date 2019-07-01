using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanRosa.Entidades
{
    public class InscripcionDetalle
    {
        public int ID { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }
        public int EstudianteId { get; set; }
        public decimal Total { get; set; }


        public InscripcionDetalle()
        {
            ID = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            EstudianteId = 0;
            Total = 0;

        }

        public InscripcionDetalle(int iD, int inscripcionId, int asignaturaId, int estudianteId,decimal total)
        {
            ID = iD;
            InscripcionId = inscripcionId;
            AsignaturaId = asignaturaId;
            EstudianteId = estudianteId;
            Total = total;
        }
    }
}
