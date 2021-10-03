using Fysio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Fysio.Data
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

        public Patient Get(int Patientnummer) =>
            (from patient in Patients
             where patient.Patiëntnummer == Patientnummer
             select patient).First();

        public void Remove(int id)
        {
            Patients.Remove(Get(id));
        }

        public void Update(Patient entity, int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
