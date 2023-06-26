using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Print(int[] arr) {
            foreach (var item in arr) {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var marks = new int[] { 34,45,65,67,87,97,34,75,78,98};
            var filtered = (from item in marks where item >= 75 select item).ToArray();
            /*var filtered = new int[marks.Length];
            var count_ = 0;
            foreach (var item in marks) {
                if (item >= 75) { 
                    filtered[count_++] = item;
                }
            }*/
            Print(marks);
            Print(filtered);

        }
    }
}
