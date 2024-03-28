using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public class EntityRepository<T> : IRepository<T> where T : Entity
    {
        private List<T> _entities;
        private int _nextId = 1;
        public T Add(T entity)
        {
           entity.Id = _nextId++;
           _entities.Add(entity);
           return entity; 
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(d => d.Id == id);
        }

        public U GetById<U>(List<U> entities, int id) where U : Entity
        {
            return entities.FirstOrDefault(e => e.Id == id);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
