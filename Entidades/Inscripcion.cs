using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanRosa.Entidades
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal PrecioCredito { get; set; }

        public List<InscripcionDetalle> Inscripciones;

        public void CalcularMonto()
        {
            
            Monto=Inscripciones.Sum(p => p.Total);
        }

        public Inscripcion()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Inscripciones = new List<InscripcionDetalle>();
            PrecioCredito = 0;
        }

        public Inscripcion(int inscripcionId, DateTime fecha, decimal monto,decimal precioCredito)
        {
            InscripcionId = inscripcionId;
            Fecha = fecha;
            Monto = monto;
            PrecioCredito = precioCredito;
        }
    }
}
