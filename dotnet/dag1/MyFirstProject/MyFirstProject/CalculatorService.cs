using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public interface ICalculatorService
    {
        int Add(int v1, int v2);
    }

    public class CalculatorService : ICalculatorService
    {
        public int Add(int value1, int value2) {
            return value1 + value2;
        }
    }
}
