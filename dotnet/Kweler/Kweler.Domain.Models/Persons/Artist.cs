using Kweler.Domain.Models.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Domain.Models.Persons
{
    public class Artist:Person
    {
        public string ImageUrl { get; set; }
        public string Website { get; set; }

        public virtual IEnumerable<Song> Songs { get; set; }

    }
}
