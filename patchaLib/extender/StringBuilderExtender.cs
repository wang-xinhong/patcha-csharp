using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patchaLib.extender
{
    public static class StringBuilderExtender
    {
        public static int IndexOf(this StringBuilder sb, String text, StringComparison comparision = StringComparison.InvariantCulture)
        {
            return sb.ToString().IndexOf(text, comparision);
        }
    }
}
