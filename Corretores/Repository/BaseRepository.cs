using Microsoft.EntityFrameworkCore;
using System;

namespace Corretores.Repository
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected Contexto _context;

        public BaseRepository()
        {
            _context = new Contexto();
        }


        /// <summary>
        /// Método para adicionar dados no banco via Entity Framework
        /// </summary>
        /// <param name="obj">Objeto generico definido na herança da classe filha</param>
        public void Add(TEntity obj)
        {
            //_context.Set<TEntity>().Add(obj);
            _context.Entry(obj).State = EntityState.Added;
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método para adicionar uma lista de objetos de dados no banco via Entity Framework
        /// </summary>
        /// <param name="obj">Lista do Objeto generico definido na herança da classe filha</param>
        public TEntity GetById(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Método para alterar dados do banco via Entity Framework
        /// </summary>
        /// <param name="obj">Objeto generico definido na herança da classe filha</param>
        public void Update(TEntity obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para remover dados do banco via Entity Framework
        /// </summary>
        /// <param name="obj">Objeto generico definido na herança da classe filha</param>
        public void Remove(object ID)
        {
            TEntity obj = GetById(ID);
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }


        /// <summary>
        /// Método para verificar se existe uma determinada entidade no banco
        /// </summary>
        /// <param name="obj">Id da entidade</param>
        public bool Existe(object obj)
        {
            return _context.Set<TEntity>().Find(obj) != null;
        }
    }
}
