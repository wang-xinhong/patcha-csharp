using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patchaLib.extender
{
    public static class IListExtender
    {
        public static IList<T> AddRange<T>(this IList<T> source, IList<T> adder)
        {
            if (source != null)
            {
                foreach (T x in adder)
                {
                    source.Add(x);
                }
                return source;
            }
            else if (adder != null)
            {
                return adder;
            }
            else
                return null;
        }
    }
}
