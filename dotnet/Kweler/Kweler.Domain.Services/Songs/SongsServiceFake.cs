using System;
using System.Collections.Generic;
using System.Text;
using Kweler.Domain.Models.Songs;

namespace Kweler.Domain.Services.Songs
{
    public class SongsServiceFake : ISongsService
    {
        public IEnumerable<Song> GetAll()
        {
            var songs = new List<Song>() {
                new Song(){
                    Id =new Guid("5DC85CE0-D978-4112-AC5D-9A30CE70F175"),
                    Title = "Er zit meer in een liedje dan je denkt",
                    IsDeleted = false
                },
                new Song(){
                    Id =new Guid("25A5C147-7F60-421C-8213-3FBCC6293A7D"),
                    Title = "Er zit meer in een liedje dan je denkt",
                    IsDeleted = false
                },
                new Song(){
                    Id =new Guid("C47F59CA-0007-4E16-93F5-93C5A5848209"),
                    Title = "Er zit meer in een liedje dan je denkt",
                    IsDeleted = false
                },
            };

            return songs;
        }

        public Song Add(Song item)
        {
            item.Id = Guid.NewGuid();
            // opslaan en van die dingen
            return item;
        }
    }
}
