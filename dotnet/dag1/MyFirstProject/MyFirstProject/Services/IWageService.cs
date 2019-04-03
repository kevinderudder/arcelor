using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Services
{
    public interface IWageService
    {
        decimal calculateWage(Employee e);
    }
}
