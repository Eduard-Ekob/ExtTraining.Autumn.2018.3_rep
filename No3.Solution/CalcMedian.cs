using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class CalcMedian
    {
        public class Calculator : ICalculator
        {
            public double CalcAverage(IEnumerable<double> value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                var sortedValue = value.OrderBy(x => x).ToList();
                int n = sortedValue.Count;

                if (n % 2 == 1)
                {
                    return sortedValue[(n - 1) / 2];
                }

                return (sortedValue[sortedValue.Count / 2 - 1] + sortedValue[n / 2]) / 2;
            }
        }
    }
}