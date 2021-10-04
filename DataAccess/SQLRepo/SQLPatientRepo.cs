using DataAccess.Data;
using Fysio.DataAccess;
using Fysio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Fysio.Data
{
    public class SQLPatientRepo : ISQLRepo<Patient>
    {

        private FysioDbContext _dbContext;

        public SQLPatientRepo(FysioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Patient entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public List<Patient> Get()
        {
            return _dbContext.Patients.ToList();
        }

        public Patient Get(int Patiëntnumber) =>
            (from student in _dbContext.Patients.ToList()
             where student.Patiëntnumber == Patiëntnumber
             select student).First();

        public void Remove(int Patiëntnumber)
        {
            _dbContext.Patients.Remove(Get(Patiëntnumber));
        }

        public void Update(Patient entity, int Patiëntnumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
