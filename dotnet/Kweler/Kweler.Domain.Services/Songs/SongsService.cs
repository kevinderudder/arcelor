using System;
using System.Collections.Generic;
using System.Text;
using Kweler.Data.Repositories.Songs;
using Kweler.Domain.Models.Songs;

namespace Kweler.Domain.Services.Songs
{
    public class SongsService : ISongsService
    {
        public IEnumerable<Song> GetAll()
        {
            var repo = new SongsRepository();
            return repo.GetAll();
        }
    }
}
