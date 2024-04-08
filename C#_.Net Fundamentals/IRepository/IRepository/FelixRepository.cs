using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public class FelixRepository
    {
        private List<Entity> entities { get; set; }

        public void AddItem(Entity entity)
        {
            entities.Add(entity);
        }

        public T GetItemById<T>(int id) where T : Entity
        {
            return entities.FirstOrDefault(x => x is T && x.Id == id) as T;
        }
    }
}
