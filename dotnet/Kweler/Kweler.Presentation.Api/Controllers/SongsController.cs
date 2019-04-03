using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kweler.Domain.Services.Songs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kweler.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ISongsService _songsService;

        public SongsController(ISongsService songsService)
        {
            this._songsService = songsService;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(this._songsService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id) {
            var allSongs = this._songsService.GetAll();
            var oneSong = allSongs.Where(s => s.Id == id).SingleOrDefault();

            if (oneSong == null) return NotFound();
            return Ok(oneSong);
        }
        
    }
}