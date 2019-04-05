using Kweler.Domain.Models.Persons;
using Kweler.Domain.Models.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kweler.Presentation.Api.Models
{
    public class SongViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
