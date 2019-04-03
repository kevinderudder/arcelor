using Kweler.Domain.Models.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Domain.Models.Songs
{
    public class Song:IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Lyrics { get; set; }
    }
}
