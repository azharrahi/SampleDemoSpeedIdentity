using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample
{
    /// <summary>
    /// Trinomial implements ITrinomial interface for the mathematical operations which contains three (or terms)
    /// </summary>
    public class Trinomial : ITrinomial
    {
        /// <summary>
        /// Trinomial implementats Cube method in ITrinomial to take cube of trinomial expression
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public long Cube(int x, int y, int z)
        {
            long n = x + y + z;
            return n * n * n;
        }

        /// <summary>
        /// Trinomial implementats Square method in ITrinomial to take square of trinomial expression
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public long Square(int x, int y, int z)
        {
            long n = x + y + z;
            return n * n;
        }
    }
}
