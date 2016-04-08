using java.awt.image;
using org.patchca.color;
using org.patchca.filter.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.patchca.filter.predefined
{
    public class CurvesWithDiffuseRippleFilterFactory : CurvesRippleFilterFactory
    {
        protected internal DiffuseImageOp diffuse = new DiffuseImageOp();

        public CurvesWithDiffuseRippleFilterFactory(ColorFactory cf) : base(cf)
        {
        }

        protected internal override IList<BufferedImageOp> PreRippleFilters
        {
            get
            {
                IList<BufferedImageOp> list = new List<BufferedImageOp>();
                list.Add(curves);
                list.Add(diffuse);
                return list;
            }
        }

    }
}
