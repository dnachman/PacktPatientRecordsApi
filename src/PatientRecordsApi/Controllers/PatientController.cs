using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientRecordsApi.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientRecordsApi.Controllers
{
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        Patient[] patients = new Patient[]
        {
            new Patient
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                SocialSecurityNumber = "123550012"
            },
            new Patient
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                SocialSecurityNumber = "123550013"
            },
            new Patient
            {
                Id = 3,
                FirstName = "Sally",
                LastName = "Smith",
                SocialSecurityNumber = "123550014"
            }
        };

        // GET: api/values
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return patients;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            var patient = patients.FirstOrDefault((p) => p.Id == id);
            if (patient == null)
            {
                return null;
            }
            return patient;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
