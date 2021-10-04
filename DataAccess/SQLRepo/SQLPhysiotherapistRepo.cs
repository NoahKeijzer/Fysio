using Fysio.DataAccess;
using Fysio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLRepo
{
    public class SQLPhysiotherapistRepo
    {
        private FysioDbContext _dbContext;

        public SQLPhysiotherapistRepo(FysioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Physiotherapist entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public List<Physiotherapist> Get()
        {
            return _dbContext.Physiotherapists.ToList();
        }

        public Physiotherapist Get(int BIGNummer) =>
            (from physiotherapist in _dbContext.Physiotherapists.ToList()
             where physiotherapist.BIGNummer == BIGNummer
             select physiotherapist).First();

        public void Remove(int BIGNummer)
        {
            _dbContext.Physiotherapists.Remove(Get(BIGNummer));
        }

        public void Update(Student entity, int BIGNummer)
        {
            throw new System.NotImplementedException();
        }
    }
}
