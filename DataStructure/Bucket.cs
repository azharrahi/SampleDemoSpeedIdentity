using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// Bucket class implements ISort interface
    /// Bucket Class will sort numbers in Ascending or Descending order
    /// Bucket sort uses Divide and Conqure Rule
    /// </summary>
    public class Bucket : ISort
    {
        /// <summary>
        /// Sort method will sort the numbers in ascending order
        /// </summary>
        /// <param name="numArray">Pass a list of int as argument</param>
        /// <returns>Returns a list of int</returns>
        public List<int> Sort(List<int> numArray)
        {
            if (numArray.Count <= 1)
                return numArray;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = numArray.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the numArray list
            {
                left.Add(numArray[i]);
            }
            for (int i = middle; i < numArray.Count; i++)
            {
                right.Add(numArray[i]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }

        /// <summary>
        /// Merge method will merge the numbers in ascending order - This method will be used by Sort method
        /// </summary>
        /// <param name="numArray">Pass two lists of int as left and right argument to merge</param>
        /// <returns>Returns a list of int</returns>
        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

        /// <summary>
        /// SortByDesc method will sort the numbers in descending order
        /// </summary>
        /// <param name="numArray">Pass a list of int as argument</param>
        /// <returns>Returns a list of int</returns>
        public List<int> SortByDesc(List<int> numArray)
        {
            if (numArray.Count <= 1)
                return numArray;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = numArray.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the numArray list
            {
                left.Add(numArray[i]);
            }
            for (int i = middle; i < numArray.Count; i++)
            {
                right.Add(numArray[i]);
            }

            left = SortByDesc(left);
            right = SortByDesc(right);
            return MergeByDesc(left, right);
        }

        /// <summary>
        /// Merge method will merge the numbers in ascending order - This method will be used by SortByDesc method
        /// </summary>
        /// <param name="numArray">Pass two lists of int as left and right argument to merge</param>
        /// <returns>Returns a list of int</returns>
        private static List<int> MergeByDesc(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() >= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
