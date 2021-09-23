using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public static class ListHelper
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] % 2 != 0)
                {
                    result.Add(listOfNumbers[i]);
                }
            }
            return result;
        }
    }
}
