using Kweler.Domain.Models.Persons;
using Kweler.Domain.Models.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Data.Repositories.Songs
{
    public class SongsRepository
    {
        public IEnumerable<Song> GetAll() {

            var a = new Artist();
            a.Id = Guid.NewGuid();
            a.Firstname = "Dan";
            a.Lastname = "Auerbach";
            a.DateOfBirth = new DateTime(1979, 5, 14);
            a.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Dan_Auerbach_performing_with_the_Black_Keys.jpg/1920px-Dan_Auerbach_performing_with_the_Black_Keys.jpg";

            var s1 = new Song();
            s1.Artist = a;
            s1.Id = Guid.NewGuid();
            s1.Title = "Mean Monsoon";
            s1.CreatedDate = DateTime.Now.AddYears(-4);

            var s2 = new Song();
            s2.Artist = a;
            s2.Id = Guid.NewGuid();
            s2.Title = "Going home";
            s2.CreatedDate = DateTime.Now.AddYears(-4);

            var s3 = new Song();
            s3.Artist = a;
            s3.Id = Guid.NewGuid();
            s3.Title = "Whispered words";
            s3.CreatedDate = DateTime.Now.AddYears(-4);

            var songs = new List<Song>();
            songs.Add(s1);
            songs.Add(s2);
            songs.Add(s3);

            return songs;
        }
    }
}
