using StringManipulation.Helper;
using StringManipulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public static class ProcessStrings
    {
        public static List<string> SortingOperations(string[] stringsArray)
        {
            List<string> result = new List<string>();
            
            foreach (string stringValue in stringsArray)
            {
                List<StringCounter> list = (from letter in stringValue
                                           group letter by letter into test
                                           select new StringCounter
                                           {
                                               Letter = test.Key,
                                               Count = test.Count()
                                           }).ToList();
                list.Sort(new StringCounterComparer());

                string stringSorted = string.Empty;
                foreach (var item in list)
                {
                    stringSorted += new string(item.Letter, item.Count);
                }
                result.Add(stringSorted);
            };

            return result;
        }
    }
}
