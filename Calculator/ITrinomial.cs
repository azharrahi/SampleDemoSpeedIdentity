using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSample
{
    /// <summary>
    /// ITrinomial provides interface for the mathematical operations which contains three variables (or terms)
    /// </summary>
    public interface ITrinomial
    {
        /// <summary>
        /// Square implementation must be provided to take square of trinomial expression
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        long Square(int x, int y, int z);

        /// <summary>
        /// Cube implementation must be provided to take cube of trinomial expression
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        long Cube(int x, int y, int z);
    }
}
