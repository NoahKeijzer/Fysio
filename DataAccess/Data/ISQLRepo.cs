using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface ISQLRepo<T>
    {
        public IEnumerable<T> Get();
        public T Get(int id);
        public void Remove(int id);
        public void Create(T entity);
        public void Update(T entity, int id);

    }
}
