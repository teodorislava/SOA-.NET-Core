using System.Collections.Generic;
using doctorsMicroservice.Models;

namespace doctorsMicroservice.Repositories
{
    public class DoctorsRepository : IDoctorsRepository
    {
        static List<Doctor> doctors = new List<Doctor>() {
            new Doctor(){
                FirstName = "Doktor",
                LastName = "Doktoric",
                ID = 1,
                Speciality = "Cardiologist"
            },
            new Doctor(){
                FirstName = "Stevan",
                LastName = "Peric",
                ID = 2,
                Speciality = "Psychiatrist"
            },
            new Doctor(){
                FirstName = "Marija",
                LastName = "Rancic",
                ID = 3,
                Speciality = "Endocrinologist"
            }
        };
        public void AddDoctor(Doctor d)
        {
            doctors.Add(d);
        }

        public List<Doctor> GetDoctors()
        {
            return doctors;
        }
    }
}