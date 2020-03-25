using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using doctorsMicroservice.Models;
using doctorsMicroservice.Repositories;

namespace doctorsMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private IDoctorsRepository repository { get; set; }
        public DoctorsController(IDoctorsRepository repository)
        {
            this.repository = repository;
        }

        // GET api/doctors
        [HttpGet("")]
        public ActionResult<IEnumerable<Doctor>> GetDoctors()
        {
            return this.repository.GetDoctors();
        }

        // POST api/doctors
        [HttpPost("")]
        public ActionResult PostDoctor(Doctor d)
        {
            this.repository.AddDoctor(d);
            return Ok();
        }

        // GET api/doctors/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return null;
        }

        // PUT api/doctors/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        // DELETE api/doctors/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}