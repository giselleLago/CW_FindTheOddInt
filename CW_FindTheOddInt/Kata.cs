using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_FindTheOddInt
{
    public class Kata
    {
        public int find_it(int[] seq)
        {
            return seq.GroupBy(g => g).Single(x => x.Count() % 2 != 0).Key;
            /*var countOfItems = new Dictionary<int, int>();
            foreach (int eachNumber in seq)
            {
                
                if (countOfItems.ContainsKey(eachNumber))
                {
                    countOfItems[eachNumber]++;
                }
                else
                {
                    countOfItems.Add(eachNumber, 1);
                }
                    
            }
            foreach (var item in countOfItems)
            {
                if (item.Value % 2 != 0)
                {
                    return item.Key;
                }
            }
            return -1;*/
        }
    }
}
