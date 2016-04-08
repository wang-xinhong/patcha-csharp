using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace patchaLib.extender
{
    public static class RandomExtender
    {
        public static float nextFloat(this Random random)
        {
            return (float)random.NextDouble();
        }

    }
}
