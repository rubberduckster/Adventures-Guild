using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Helpers
{
    public static class SearchHelper
    {
        public static List<T> Filter<T>(List<T> items, Func<T, bool> condition)
        {
            List<T> results = new List<T>();

            foreach (T item in items)
            {
                if (condition(item))
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}
