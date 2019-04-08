using Kweler.Domain.Models.Songs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kweler.Data.Repositories.Songs
{
    public class SongsRepository:IRepository<Song>
    {
        private Context _ctx;

        public SongsRepository(Context ctx)
        {
            this._ctx = ctx;
        }

        public Song Add(Song item)
        {
           var newitem = _ctx.Songs.Add(item);
           _ctx.SaveChanges();
           return newitem.Entity;
        }

        public IEnumerable<Song> GetAll() {
            return _ctx.Songs.ToList();
        }

        public Song GetById(Guid id)
        {
            return _ctx.Songs.Where(s => s.Id == id).SingleOrDefault();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Song Update(Song item)
        {
            throw new NotImplementedException();
        }
    }
}
