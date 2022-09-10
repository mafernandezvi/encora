using StringManipulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Helper
{
    public class StringCounterComparer : IComparer<StringCounter>
    {
        public int Compare(StringCounter? x, StringCounter? y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x == null)
            {
                return -1;
            }

            if (y == null)
            {
                return 1;
            }

            if (x.Count < y.Count)
                return 1;
            else if (y.Count < x.Count)
                return -1;
            else
            {
                return x.Letter.CompareTo(y.Letter);
            }
        }
    }
}
