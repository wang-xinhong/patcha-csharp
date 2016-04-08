using System.Collections.Generic;

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
	using java.awt.image;
	using DoubleRippleImageOp = org.patchca.filter.library.DoubleRippleImageOp;



	public class DoubleRippleFilterFactory : AbstractFilterFactory
	{

		protected internal IList<BufferedImageOp> filters;
		protected internal DoubleRippleImageOp ripple;

		public DoubleRippleFilterFactory()
		{
			ripple = new DoubleRippleImageOp();
		}

		public override IList<BufferedImageOp> Filters
		{
			get
			{
				if (filters == null)
				{
					filters = new List<BufferedImageOp>();
					filters.Add(ripple);
				}
				return filters;
			}
			set { }
		}

	}

}