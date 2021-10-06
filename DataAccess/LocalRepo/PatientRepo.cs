using DataAccess.Data;
using Domain.DomainModels;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.LocalRepo
{
    public class PatientRepo : IRepo<Patient>
    {
        public static List<Patient> Patients = new List<Patient>();
        public void Create(Patient entity)
        {
            Patients.Add(entity);
        }

        public List<Patient> Get()
        {
            return Patients.ToList();
        }

        public Patient Get(int Patiëntnumber) =>
            (from patient in Patients
             where patient.Patiëntnumber == Patiëntnumber
             select patient).First();

        public void Remove(int Patiëntnumber)
        {
            Patients.Remove(Get(Patiëntnumber));
        }

        public void Update(Patient entity, int Patiëntnumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
