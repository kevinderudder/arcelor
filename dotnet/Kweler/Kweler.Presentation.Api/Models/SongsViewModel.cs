using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kweler.Presentation.Api.Models
{
    public class SongsViewModel
    {
        public List<SongViewModel> Songs { get; set; } = new List<SongViewModel>();
    }
}
