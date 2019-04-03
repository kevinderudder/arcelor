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
    public class QuestionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            return Ok(new List<string>() {
                "Wat is stateless?",
                "Wat is SOLID"
            });
        }

        [HttpGet("{id}")]
        public IActionResult get(int id) {
            if (id == 66) return NotFound();
            return Ok("Wat is SOLID");
        }
    }
}