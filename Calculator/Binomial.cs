using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample
{
    /// <summary>
    /// Binomial implements IBinomial interface for the mathematical operations which contains two variables (or terms)
    /// </summary>
    public class Binomial : IBinomial
    {
        /// <summary>
        /// Binomial implementats Cube method in IBinomial to take cube of binomial expression
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public long Cube(int x, int y)
        {
            long n = x + y;
            return n * n * n;
        }

        /// <summary>
        /// Binomial implementats Square method in IBinomial to take square of binomial expression
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public long Square(int x, int y)
        {
            long n = x + y;
            return n * n;
        }
    }
}
