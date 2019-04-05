using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kweler.Domain.Models.Songs;
using Kweler.Domain.Services.Songs;
using Kweler.Presentation.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kweler.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class SongsController : ControllerBase
    {
        private readonly ISongsService _songsService;

        public SongsController(ISongsService songsService)
        {
            this._songsService = songsService;
        
        }

        [HttpGet]
        public IActionResult Get() {
            var songs = _songsService.GetAll();
            var songsViewModels = new SongsViewModel();

            foreach(var s in songs) {
                var newSM = new SongViewModel();
                newSM.Id = s.Id;
                newSM.Title = s.Title;
                newSM.Lyrics = s.Lyrics;
                newSM.Artists = s.Artists;
                newSM.CreatedDate = s.CreatedDate;

                songsViewModels.Songs.Add(newSM);
            }
            return Ok(songsViewModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id) {
            var allSongs = this._songsService.GetAll();
            var oneSong = allSongs.Where(s => s.Id == id).SingleOrDefault();

            if (oneSong == null) return NotFound();
            return Ok(oneSong);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Song song) {
            return Ok(song);
        }
        
    }
}