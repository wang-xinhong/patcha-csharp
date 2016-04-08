using System.Collections.Generic;
using java.awt.image;

/*
 * Copyright (c) 2009 Piotr Piastucki
 * 
 * This file is part of Patchca CAPTCHA library.
 * 
 *  Patchca is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *  
 *  Patchca is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *  
 *  You should have received a copy of the GNU Lesser General Public License
 *  along with Patchca. If not, see <http://www.gnu.org/licenses/>.
 */
namespace org.patchca.filter.predefined
{
	using ColorFactory = org.patchca.color.ColorFactory;
	using CurvesImageOp = org.patchca.filter.library.CurvesImageOp;


	public class CurvesRippleFilterFactory : RippleFilterFactory
	{

		protected internal CurvesImageOp curves = new CurvesImageOp();

		public CurvesRippleFilterFactory()
		{
		}

		public CurvesRippleFilterFactory(ColorFactory colorFactory)
		{
			ColorFactory = colorFactory;
		}

		protected internal override IList<BufferedImageOp> PreRippleFilters
		{
			get
			{
				IList<BufferedImageOp> list = new List<BufferedImageOp>();
				list.Add(curves);
				return list;
			}
		}

		public virtual float StrokeMin
		{
			set
			{
				curves.StrokeMin = value;
			}
		}

		public virtual float StrokeMax
		{
			set
			{
				curves.StrokeMax = value;
			}
		}

		public virtual ColorFactory ColorFactory
		{
			set
			{
				curves.ColorFactory = value;
			}
		}

	}

}