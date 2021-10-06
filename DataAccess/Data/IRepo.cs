using System.Collections.Generic;

namespace DataAccess.Data
{
    public interface IRepo<T>
    {
        public List<T> Get();
        public T Get(int id);
        public void Remove(int id);
        public void Create(T entity);
        public void Update(T entity, int id);
    }
}
