using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]")]
        public  IEnumerable<Employee> getemployees()
        {
            using(var context = new testContext())
            {
                return context.Employees.ToList();
            }
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IEnumerable<Employee> getemployees(int id)
        {
            using (var context = new testContext())
            {
                var result = context.Employees.Where(emp => emp.Id == id).ToList();
                if(result.Count > 0)
                {
                    return result;
                }
                return null;
                
            }
        }
    }
}
