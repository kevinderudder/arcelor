using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstProject.Models;

namespace MyFirstProject.Services
{
    public class WageService : IWageService
    {
        public decimal calculateWage(Employee e)
        {
            return e.Wage * 1.1M;
        }
    }
}
