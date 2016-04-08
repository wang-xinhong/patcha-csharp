using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patchaLib.extender
{
    public static class Java_Util_ListExtender
    {
        public static IList<String> getIList(this java.util.List list)
        {
            List<String> result = new List<string>();

            foreach (var obj in list.toArray())
            {
                if (obj.GetType().Equals(typeof(String)))
                    result.Add(obj as String);
                else
                    result.Add(obj.ToString());
            }

            return result;
        }

    }
}
