using Kweler.Domain.Models.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Data.Repositories.Songs
{
    public interface ISongsRepository
    {
        IEnumerable<Song> GetAll();
        Song GetById(Guid id);
        Song Add(Song song);
        Song Update(Song song);
        bool Remove(Guid id);
    }
}
