using Kweler.Domain.Models.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Domain.Models.Songs
{
    public class SongArtist:IEntity
    {
        public Guid Id { get; set; }

        public Guid ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public Guid SongId { get; set; }
        public virtual Song Song { get; set; }
    }
}
