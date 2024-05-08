using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearch binarySearch = new BinarySearch(20, 1, 25);
            binarySearch.GetAnver(5);
            Console.WriteLine("Add message");
            Console.WriteLine("add two message");
        }
    }
}
