using Fysio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Fysio.Data
{
    public class StudentRepo : IRepo<Student>
    {
        public List<Student> Students = new List<Student>();
        public void Create(Student entity)
        {
            Students.Add(entity);
        }

        public List<Student> Get()
        {
            return Students.ToList();
        }

        public Student Get(int Studentnumber) =>
            (from student in Students
             where student.Studentnumber == Studentnumber
             select student).First();

        public void Remove(int Studentnumber)
        {
            Students.Remove(Get(Studentnumber));
        }

        public void Update(Student entity, int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
