using System;
using System.Collections.Generic;
using System.Text;

namespace Kweler.Domain.Models.Persons
{
    public abstract class Person : IEntity
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
