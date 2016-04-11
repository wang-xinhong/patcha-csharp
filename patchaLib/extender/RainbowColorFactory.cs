using java.awt;
using org.patchca.color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patchaLib.extender
{
    /// <summary>
    /// Do not use this,not quite good
    /// </summary>
    public class RainbowColorFactory : ColorFactory
    {
        private static java.util.Random random = new java.util.Random();

        public Color getColor(int x)
        {
            int[] c = new int[3];
            int i = random.nextInt(c.Length);
            for (int fi = 0; fi < c.Length; fi++)
            {
                if (fi == i)
                {
                    c[fi] = random.nextInt(71);
                }
                else {
                    c[fi] = random.nextInt(256);
                }
            }
            return new Color(c[0], c[1], c[2]);
        }

    }
}
