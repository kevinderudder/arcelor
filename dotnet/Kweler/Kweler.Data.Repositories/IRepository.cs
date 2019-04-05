using Kweler.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Data.Repositories
{
    public interface IRepository<T> where T:IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        T Add(T item);
        T Update(T item);
        bool Remove(Guid id);
    }
}
