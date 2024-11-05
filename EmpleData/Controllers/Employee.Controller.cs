using EmpleData.Funtions;
using EmployeeData.Models;
using EmployeeData.Services; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace EmpleData.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public GeneralFunction FunctionGeneral;
        public IConfiguration _Configuration { get; set; }

        public EmployeeController(IConfiguration configuration, EmployeeService employeeService) 
        {
            _employeeService = employeeService;
            FunctionGeneral = new GeneralFunction();
            _Configuration = configuration;
        }

        [HttpPost("RegisterEmployee")]
        public IActionResult RegisterEmployee([FromBody] Employee employee) 
        {
            try
            {
                _employeeService.Add(employee); 
                return Ok("Empleado creado con éxito."); 
            }
            catch (Exception ex)
            {
                FunctionGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString()); 
            }
        }

        [HttpGet("GetEmployee")]
        public ActionResult<IEnumerable<Employee>> GetEmployees() 
        {
            try
            {
                var employees = _employeeService.GetEmployee(); 
                return Ok(employees); 
            }
            catch (Exception ex)
            {
                FunctionGeneral.Addlog(ex.ToString());
                return StatusCode(500, ex.ToString()); 
            }
        }
    }
}
