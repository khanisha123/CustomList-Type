using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList_Type
{
    class Count
    {
        private int[] numbers = { 1, 2, 3, 4, 9, 7, 5, 0, 2 };
        public int NuberOfElements;
        public Count()
        {
            NuberOfElements = numbers.Length;
        }
        public int ValidEntries() 
        {
            int count = 0;
            for (int i = 0; i < NuberOfElements; i++)
            {
                if (numbers[i]>=0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
