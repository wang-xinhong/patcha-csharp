using System;

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
namespace org.patchca.filter.library
{

	public class DoubleRippleImageOp : RippleImageOp
	{

		protected internal override void transform(int x, int y, double[] t)
		{
			double tx = Math.Sin((double) y / yWavelength + yRandom) + 1.3 * Math.Sin((double) 0.6 * y / yWavelength + yRandom);
			double ty = Math.Cos((double) x / xWavelength + xRandom) + 1.3 * Math.Cos((double) 0.6 * x / xWavelength + xRandom);
			t[0] = x + xAmplitude * tx;
			t[1] = y + yAmplitude * ty;
		}

	}

}