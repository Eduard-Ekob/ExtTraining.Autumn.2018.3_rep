using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class CalcAverageByMean : ICalculator
    {
        public double CalcAverage(IEnumerable<double> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return value.Sum() / value.Count();
        }
    }
}
