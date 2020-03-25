using System.Collections.Generic;
using patientsMicroservice.Models;

namespace patientsMicroservice.Repositories
{
    public interface IPatientsRepository
    {
        public List<Patient> GetPatients();
        public void AddPatient(Patient p);
    }
}