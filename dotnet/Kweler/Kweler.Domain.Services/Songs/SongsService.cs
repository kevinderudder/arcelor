using System;
using System.Collections.Generic;
using System.Text;
using Kweler.Data.Repositories;
using Kweler.Data.Repositories.Songs;
using Kweler.Domain.Models.Songs;

namespace Kweler.Domain.Services.Songs
{
    public class SongsService : ISongsService
    {
        private IRepository<Song> _songsRepository;

        public SongsService(IRepository<Song> songsRepository)
        {
            this._songsRepository = songsRepository;
        }

        public IEnumerable<Song> GetAll()
        {
            //var repo = new SongsRepository();
            return _songsRepository.GetAll();
        }
    }
}
