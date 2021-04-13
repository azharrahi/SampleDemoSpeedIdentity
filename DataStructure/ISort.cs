using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// ISort interface must be implemented by a class in order to sort numbers in Ascending or Descending order
    /// Any class can implement ISort methods in any way to achieve sorting
    /// </summary>

    interface ISort
    {
        /// <summary>
        /// Sort an array in Ascending order
        /// </summary>
        /// <param name="numArray">Pass a list of int as argument</param>
        /// <returns>Returns a list of int</returns>
        List<int> Sort(List<int> numArray);

        /// <summary>
        /// Sort an array in Descending order
        /// </summary>
        /// <param name="numArray">Pass a list of int as argument</param>
        /// <returns>Returns a list of int</returns>
        List<int> SortByDesc(List<int> numArray);
    }
}
