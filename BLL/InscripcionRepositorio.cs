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

               

                if(ins!=null)
                {
                    ins.Inscripciones.Count();
                }

            }
            catch (Exception)
            {

                throw;
            }
            return ins;
        }

        public override bool Modificar(Inscripcion entity)
        {
            Repositorio<Estudiantes> estudiante = new Repositorio<Estudiantes>();
            bool paso = false;
            try
            {
                var ids = entity.Inscripciones.Select(p => p.EstudianteId);
                var asg = entity.Inscripciones.Select(p => p.AsignaturaId);
                var anterior = new Repositorio<Inscripcion>().Buscar(entity.InscripcionId);

                foreach (var item in ids)
                {
                   var estu = estudiante.Buscar(item);
                    estu.Balance-=anterior.Monto;

                }

               

                foreach (var item in entity.Inscripciones)
                {
                    if (!entity.Inscripciones.Any(d => d.ID == item.ID))
                        _contexto.Entry(item).State = EntityState.Deleted;
                }
                foreach (var item in entity.Inscripciones)
                {
                    var estado = item.ID > 0 ? EntityState.Modified : EntityState.Added; 
                    _contexto.Entry(item).State = estado;
                }
                
               
                entity.CalcularMonto();


                foreach (var item in ids)
                {
                    var estu = estudiante.Buscar(item);
                    estu.Balance += entity.Monto;

                }


                foreach (var item in ids)
                {
                    var estu = estudiante.Buscar(item);
                    estudiante.Modificar(estu);

                }
                _contexto.Entry(entity).State = EntityState.Modified;

                paso = _contexto.SaveChanges() > 0;


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
                Repositorio<Estudiantes> Est = new Repositorio<Estudiantes>();
                

                    foreach (var items in ins.Inscripciones)
                    {
                        Estudiantes resultado = _contexto.Estudiantes.Find(items.EstudianteId);
                        resultado.Balance -= items.Total;

                    }
                    paso = _contexto.SaveChanges() > 0;

                

            }
            catch (Exception)
            {

                throw;
            }
            _contexto.Dispose();
            return paso;
        }

        public override bool Guardar(Inscripcion entity)
        {
            bool paso = false;
            //decimal resultado;
            try
            {
                Repositorio<Estudiantes> Est = new Repositorio<Estudiantes>();
                if (_contexto.Inscripcion.Add(entity)!=null)
                {
                    
                    foreach (var items in entity.Inscripciones)
                    {
                        var resultado = _contexto.Estudiantes.Find(items.EstudianteId);
                        resultado.Balance = items.Total;
                        

                    }
                    paso = _contexto.SaveChanges() > 0;

                }
                    
                
                
            }
           
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public bool Existe(int id)
        {
            bool paso = false;
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
    }
    

}
