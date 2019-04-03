using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Models;
using MyFirstProject.Services;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IWageService _wageService;
        public EmployeeController(IWageService wageService)
        {
            this._wageService = wageService;
        }
        public IActionResult Wage(int id)
        {
            if (id == 66) return NotFound();
            Employee e = new Employee() {
                Firstname = "Kevin",
                Lastname = "DeRudder",
                Age = 42,
                Wage = 8900
            };
            e.Wage = _wageService.calculateWage(e);
            return Ok(e);
        }
    }
}