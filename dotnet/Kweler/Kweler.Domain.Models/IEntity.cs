using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Domain.Models
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
