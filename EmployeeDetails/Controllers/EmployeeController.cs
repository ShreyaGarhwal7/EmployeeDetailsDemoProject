using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeDetails.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET: api/Employee
   
        [HttpGet]
        public IEnumerable<EmployeeDetail> Get()
        {
            using (var employeeDBEntities = new EmployeeEntities1())
            {
                var emp = employeeDBEntities.EmployeeDetails.ToList();
                return emp;
            }
        }

        [HttpGet]
        // GET: api/Employee/5
        public EmployeeDetail Get(int id)
        {
            using (var employeeDBEntities = new EmployeeEntities1())
            {
                var employee = employeeDBEntities.EmployeeDetails.FirstOrDefault(e => e.Id == id);
                if (employee == null)
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
                }
                return employee;
            }
        }

        [HttpPost]
        // POST: api/Employee
        public void Post([FromBody]EmployeeDetail empDetail)
        {
            using (var employeeDBEntities = new EmployeeEntities1())
            {
                employeeDBEntities.EmployeeDetails.Add(empDetail);

                employeeDBEntities.SaveChanges();
            }
        }

        [HttpPut]
        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
