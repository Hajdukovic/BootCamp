using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lists.WebApi.Controllers
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Balance { get; set; }
        public string WorkingHours { get; set; }

        public string PrintInfo()
        {
            return ("Employee " + this.Name + " " + this.Surname + " has this much on account: " + this.Balance);
        }
    }

    public class ValuesController : ApiController
    {
        public static List<Employee> employees = new List<Employee>();


        // GET api/values
        public HttpResponseMessage Get()
        {
            string print = "";
            foreach (Employee employee in employees)
                print += employee.PrintInfo() + ", ";
            return Request.CreateResponse(HttpStatusCode.OK, print);
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            Employee tempEmployee = employees.Find(employee => employee.Id == id);

            if (tempEmployee == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, id);
            }
            return Request.CreateResponse(HttpStatusCode.OK, tempEmployee);
        }

        // POST api/values
        public string Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return ("You added new employee");
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody] Employee employee1)
        {
            Employee tempEmployee = employees.Find(employee => employee.Id == id);
            if (tempEmployee == null)
            {
                return BadRequest("Not a valid employee id");
            }
            else
            {
                if (employee1.Name != null)
                {
                    tempEmployee.Name = employee1.Name;
                }
                if (employee1.Surname != null)
                {
                    tempEmployee.Surname = employee1.Surname;
                }
                if (employee1.Balance != null)
                {
                    tempEmployee.Balance = employee1.Balance;
                }
                if (employee1.WorkingHours != null)
                {
                    tempEmployee.WorkingHours = employee1.WorkingHours;
                }
                return Ok("Employee data changed!");
            }
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            Employee tempEmployee = employees.Find(employee => employee.Id == id);
            if (tempEmployee == null)
            {
                return BadRequest("Not a valid employee id");
            }
            else
            {
                employees.Remove(tempEmployee);
                return Ok("Employee removed!");
            }
        }
    }
}
