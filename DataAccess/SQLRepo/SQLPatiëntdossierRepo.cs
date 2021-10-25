using DataAccess.Data;
using Domain.DomainModels;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.SQLRepo
{
    public class SQLPatiëntdossierRepo : ISQLRepo<Patiëntdossier>
    {

        private FysioDbContext _dbContext;

        public SQLPatiëntdossierRepo(FysioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Patiëntdossier entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Patiëntdossier> Get()
        {
            return _dbContext.Patiëntdossiers.ToList();
        }

        public Patiëntdossier Get(int PatiëntdossierId) =>
            (from patiëntdossier in _dbContext.Patiëntdossiers.ToList()
             where patiëntdossier.Id == PatiëntdossierId
             select patiëntdossier).First();

        public void Remove(int PatiëntdossierId)
        {
            _dbContext.Patiëntdossiers.Remove(Get(PatiëntdossierId));
        }

        public void Update(Patiëntdossier entity, int PatiëntdossierId)
        {
            throw new System.NotImplementedException();
        }
    }
}
