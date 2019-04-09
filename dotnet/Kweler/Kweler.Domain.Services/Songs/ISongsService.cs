using Kweler.Domain.Models.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Domain.Services.Songs
{
    public interface ISongsService
    {
        IEnumerable<Song> GetAll();
        Song Add(Song item);
    }
}
