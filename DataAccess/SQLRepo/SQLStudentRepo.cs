using DataAccess.Data;
using Domain.DomainModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.SQLRepo
{
    public class SQLStudentRepo : ISQLRepo<Student>
    {
        private FysioDbContext _dbContext;

        public SQLStudentRepo(FysioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Student entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Student> Get()
        {
            return _dbContext.Students.ToList();
        }

        public Student Get(int Studentnumber) =>
            (from student in _dbContext.Students.ToList()
             where student.Studentnumber == Studentnumber
             select student).First();

        public void Remove(int Studentnumber)
        {
            _dbContext.Students.Remove(Get(Studentnumber));
        }

        public void Update(Student entity, int Studentnumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
