using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface ISQLRepo<T>
    {
        public List<T> Get();
        public T Get(int id);
        public void Remove(int id);
        public Task Create(T entity);
        public void Update(T entity, int id);

    }
}
