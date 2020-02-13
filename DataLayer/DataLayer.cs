using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntites;
using System.Linq.Expressions;

namespace DataLayer
{
    public class DataLayer
    {
        public interface IRepository<TEntity> where TEntity : class
        {
            TEntity Get(int id);
            IEnumerable<TEntity> GetAll();
            IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

            void Add(TEntity entity);
            void AddRange(IEnumerable<TEntity> entities);

            void Remove(TEntity entity);
            void RemoveRange(IEnumerable<TEntity> entities);
        }

        public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
        {
            public void Add(TEntity entity)
            {
                throw new NotImplementedException();
            }

            public void AddRange(IEnumerable<TEntity> entities)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
            {
                throw new NotImplementedException();
            }

            public TEntity Get(int id)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<TEntity> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Remove(TEntity entity)
            {
                throw new NotImplementedException();
            }

            public void RemoveRange(IEnumerable<TEntity> entities)
            {
                throw new NotImplementedException();
            }
        }


    }
}
