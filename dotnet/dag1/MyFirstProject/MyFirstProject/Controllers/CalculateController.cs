using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private ICalculatorService _calc;

        public CalculateController(ICalculatorService calcService)
        {
            this._calc = calcService;
        }

        public IActionResult Add() {
            return Ok(_calc.Add(2,2));
        }
    }
}

// WageService
// WageService.CalculateWage(persoon p) ==> p leeftijd 1,1
