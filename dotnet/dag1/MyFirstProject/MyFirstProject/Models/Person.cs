using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public abstract class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
      

        public override string ToString()
        {
            return $"{this.Firstname} ${this.Lastname} (${this.Age} years old)";
        }

    }
}
