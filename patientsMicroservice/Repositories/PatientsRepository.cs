using System.Collections.Generic;
using patientsMicroservice.Models;

namespace patientsMicroservice.Repositories
{
    public class PatientsRepository : IPatientsRepository
    {
        static List<Patient> patients = new List<Patient>() {
            new Patient(){
                FirstName = "Bouban",
                LastName = "Bobanic",
                ID = 1,
                Conditions = new List<string>() {
                    "madness",
                    "alcoholism"
                }
            },
            new Patient(){
                FirstName = "Milan",
                LastName = "Milanic",
                ID = 2,
                Conditions = new List<string>() {
                    "drugs",
                    "OCD"
                }
            },
            new Patient(){
                FirstName = "Silvana",
                LastName = "Kragic",
                ID = 3,
                Conditions = new List<string>() {
                    "crazy"
                }
            }
        };
    
        public void AddPatient(Patient p)
        {
            patients.Add(p);
        }

        public List<Patient> GetPatients()
        {
            return patients;
        }
    }
}