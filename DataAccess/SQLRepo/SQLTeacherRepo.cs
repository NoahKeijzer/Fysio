using Fysio.DataAccess;
using Fysio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLRepo
{
    public class SQLTeacherRepo
    {
        private FysioDbContext _dbContext;

        public SQLTeacherRepo(FysioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Teacher entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public List<Teacher> Get()
        {
            return _dbContext.Teachers.ToList();
        }

        public Teacher Get(int StaffNumber) =>
            (from teacher in _dbContext.Teachers.ToList()
             where teacher.StaffNumber == StaffNumber
             select teacher).First();

        public void Remove(int StaffNumber)
        {
            _dbContext.Teachers.Remove(Get(StaffNumber));
        }

        public void Update(Student entity, int StaffNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
