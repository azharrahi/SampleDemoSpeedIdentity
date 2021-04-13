using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample
{
    /// <summary>
    /// IBinomial provides interface for the mathematical operations which contains two variables (or terms)
    /// </summary>
    public interface IBinomial
    {
        /// <summary>
        /// Square implementation must be provided to take square of binomial expression
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        long Square(int x, int y);

        /// <summary>
        /// Cube implementation must be provided to take cube of binomial expression
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        long Cube(int x, int y);
    }
}
