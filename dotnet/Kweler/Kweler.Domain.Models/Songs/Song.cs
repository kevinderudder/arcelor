using Kweler.Domain.Models.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kweler.Domain.Models.Songs
{
    public class Song:IEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        //public Artist Artist { get; set; }

        public virtual IEnumerable<Artist> Artists { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string Lyrics { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
