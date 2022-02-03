using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiddleware.Data.Services;
using WebApiMiddleware.Data.ViewModels;

namespace WebApiMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesService _employeesService;

        public EmployeesController(EmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpPost("add-employee")]
        public IActionResult Add([FromBody] EmployeeVM employeeVM)
        {
            try
            {
                _employeesService.Add(employeeVM);
                return Ok();
            }
            catch (Exception exception) 
            {
                throw;
            }
        }
    }
}
