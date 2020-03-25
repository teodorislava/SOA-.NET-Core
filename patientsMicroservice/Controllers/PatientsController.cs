using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using patientsMicroservice.Models;
using patientsMicroservice.Repositories;
//using patientsMicroservice.Models;

namespace patientsMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private IPatientsRepository repository { get; set; }
        public PatientsController(IPatientsRepository repository)
        {
            this.repository = repository;
        }

        // GET api/patients
        [HttpGet("")]
        public ActionResult<IEnumerable<Patient>> GetPatients()
        {
            return this.repository.GetPatients();
        }

        // GET api/patients/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return null;
        }

        // POST api/patients
        [HttpPost("")]
        public ActionResult PostPatient(Patient p)
        {
            this.repository.AddPatient(p);
            return Ok();
        }

        // PUT api/patients/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        // DELETE api/patients/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}