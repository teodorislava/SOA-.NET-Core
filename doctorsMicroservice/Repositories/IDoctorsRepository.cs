using System.Collections.Generic;
using doctorsMicroservice.Models;

namespace doctorsMicroservice.Repositories
{
    public interface IDoctorsRepository
    {
        public List<Doctor> GetDoctors();
        public void AddDoctor(Doctor d);
    }
}