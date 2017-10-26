using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace SortedBag
{
    public class DAL : Interface
    {
       // List<int> All = new List<int>();

        public List<int> All = new List<int>();
        

        public int AddInteger(int i)
        {
            All.Add(i);
            return i;
        }

        public List<int> AllIntegers()
        {
            return All;
        }

        public void DeleteInteger()
        {
            All.Remove(All.Min());
 
        }

        public int CountInteger(int i)
        {
            var count = All.Count(item => item == i);
            return count;
        }
    }
}
