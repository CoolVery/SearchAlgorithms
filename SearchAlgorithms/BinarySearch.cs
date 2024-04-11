using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    internal class BinarySearch
    {
        int[] array;
        public BinarySearch(int length, int minValue, int maxValue)
        {
            array = new int[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
                
            }
            Array.Sort(array);
            for (int i = 0; i < length; i++)
            {
                Console.Write($" {array[i]} ");
            }
        }
        private int[] SearcElementBinary(int searchValue)
        {
            int start = 0;
            int end = array.Length - 1;
            int midArray;
            while(start < end)
            {
                midArray = start + end;
                int tempValue = array[midArray];
                if (tempValue == searchValue)
                {
                    return new int[] {tempValue, midArray};
                }
                else if (tempValue > searchValue)
                {
                    end -= 1;
                }
                else if (tempValue < searchValue)
                {
                    start += 1;
                }
            }
            return null;
        }
        public void GetAnver(int searchValue)
        {
            int[] answer = SearcElementBinary(searchValue);
            if (answer == null)
            {
                Console.WriteLine("Элемента нет");
            }
            else Console.WriteLine($"Элемент - {answer[0]}\nИндекс - {answer[1]}");
        }
    }
}
