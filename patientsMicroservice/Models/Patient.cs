using System.Collections.Generic;

namespace patientsMicroservice.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Conditions { get; set; }
    }
}