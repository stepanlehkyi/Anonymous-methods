using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2. Create a function an anonymous method that takes an array of numbers between 1 and 10 (excluding one number) and returns the
missing number.

Examples

MissingNum([1, 2, 3, 4, 6, 7, 8, 9, 10]) ➞ 5

MissingNum([7, 2, 3, 6, 5, 9, 1, 4, 8]) ➞ 10

MissingNum([10, 5, 1, 2, 4, 6, 8, 3, 9]) ➞ 7
*/
namespace Task_1._2
{
    public delegate int MissingNum(int[] array);
    class Program
    {
        static void Main(string[] args)
        {
            MissingNum missingNum = delegate (int[] array)
             {
                 return Enumerable.Range(1, 10).Except(array).Last();
             };
            int missNumberOne = missingNum(new int[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 });
            int missNumberTwo = missingNum(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 });
            int missNumberThree = missingNum(new int[] { 10, 5, 1, 2, 4, 6, 8, 3, 9 });
            Console.WriteLine( missNumberOne + " "+ missNumberTwo + " " + missNumberThree);


        }
    }
}
