using Parcial2_JuanRosa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanRosa.BLL
{
    public class InscripcionRepositorio:Repositorio<Inscripcion>
    {
        public override Inscripcion Buscar(int id)
        {
            Inscripcion ins = new Inscripcion();
            try
            {
                ins = _contexto.Inscripcion.Find(id);

                ins.Inscripciones.Count();

                foreach (var item in ins.Inscripciones)      
                { string s = item.AsignaturaId.ToString();  } 

            }
            catch (Exception)
            {

                throw;
            }
            return ins;
        }

        public override bool Modificar(Inscripcion entity)
        {
            bool paso = false;
            try
            {
                
                foreach (var item in entity.Inscripciones)
                {
                    if (entity.Inscripciones.Exists(d => d.ID == item.ID))
                        _contexto.Entry(item).State = EntityState.Deleted;
                }
                foreach (var item in entity.Inscripciones)
                {
                    var estado = item.ID > 0 ? EntityState.Modified : EntityState.Added; 
                    _contexto.Entry(item).State = estado;
                }
                _contexto.Entry(entity).State = EntityState.Modified;

                if (_contexto.SaveChanges() > 0)
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public override bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                Inscripcion ins = _contexto.Inscripcion.Find(id);
                _contexto.Entry(ins).State = EntityState.Deleted;
                paso = _contexto.SaveChanges() > 0;
               
            }
            catch (Exception)
            {

                throw;
            }
            _contexto.Dispose();
            return paso;
        }
    }
    
}
