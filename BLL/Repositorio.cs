using Parcial2_JuanRosa.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanRosa.BLL
{
    public class Repositorio<T> : IDisposable, IRepository<T> where T : class
    {
        internal Contexto _contexto;
        public Repositorio()
        {
            _contexto = new Contexto();
        }
        public T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            ;
            return entity;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
           List<T> Lista = new List<T>();
            try
            {
                Lista = _contexto.Set<T>().Where(p=>true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return Lista ;
        }

        public bool Guardar(T entity)
        {
            bool paso = false;
            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                    paso = _contexto.SaveChanges()>0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public bool Modificar(T entity)
        {
            bool paso = false;

            try
            {
                _contexto.Entry(entity).State = EntityState.Modified;
                paso = _contexto.SaveChanges()>0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
