using DemoMock.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Web=System.Web.Http;

namespace DemoMock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public ValuesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public ActionResult GetEmployees()
        { 
            var emps = _employeeRepository.GetEmployees();
            return Ok(emps);
        }

        [HttpGet]
        [Route("GetEmployee")]
        public ActionResult GetEmployee(int id)
        {  
            var employee = _employeeRepository.GetEmployee(id);
            if (employee == null)
            { 
                var message = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Employee Not Found")
                };
                throw new Web.HttpResponseException(message);
            }
            return Ok(employee);
        }
    }
}
