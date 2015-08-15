using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("compiled");
        }

        static public int[] Mergesort(int[] arr)
        {
            if (arr.Length == 1) return arr;
            int midPt = (int)decimal.Floor(arr.Length / 2);

            int[] left = new int[midPt];
            int[] right = new int[arr.Length - midPt];

            // source, start index in source, dest, start index in dest, how many to copy
            Array.Copy(arr, 0, left, 0, midPt);
            Array.Copy(arr, midPt, right, 0, arr.Length - midPt);

            int[] leftMergesorted = Mergesort(left);
            int[] rightMergesorted = Mergesort(right);

            return Merge(leftMergesorted, rightMergesorted);
        }

        static public int[] Merge(int[] left, int[] right)
        {
            // base cases
            if (left.Length == 0) return right;
            if (right.Length == 0) return left;

            int[] returnArr = new int[left.Length + right.Length];

            if (left[0] <= right[0])
            {
                int[] singleton = new int[] { left[0] };

                int[] newLeft = new int[left.Length - 1];
                // source, start index in source, dest, start index in dest, how many to copy
                Array.Copy(left, 1, newLeft, 0, left.Length - 1);

                int[] theRest = Merge(newLeft, right);
                singleton.CopyTo(returnArr, 0);
                theRest.CopyTo(returnArr, 1);
            } else {
                int[] singleton = new int[] { right[0] };

                int[] newRight = new int[right.Length - 1];
                // source, start index in source, dest, start index in dest, how many to copy
                Array.Copy(right, 1, newRight, 0, right.Length - 1);

                int[] theRest = Merge(left, newRight);
                singleton.CopyTo(returnArr, 0);
                theRest.CopyTo(returnArr, 1);

            }
            return returnArr;
        }
    }
}
