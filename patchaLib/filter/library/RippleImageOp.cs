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


	public class RippleImageOp : AbstractTransformImageOp
	{

		protected internal double xWavelength;
		protected internal double yWavelength;
		protected internal double xAmplitude;
		protected internal double yAmplitude;
		protected internal double xRandom;
		protected internal double yRandom;

		public RippleImageOp()
		{
			xWavelength = 20;
			yWavelength = 10;
			xAmplitude = 5;
			yAmplitude = 5;
			xRandom = 5 * new Random(1).NextDouble();
			yRandom = 5 * new Random(2).NextDouble();
		}

		public virtual double getxWavelength()
		{
			return xWavelength;
		}

		public virtual void setxWavelength(double xWavelength)
		{
			this.xWavelength = xWavelength;
		}

		public virtual double getyWavelength()
		{
			return yWavelength;
		}

		public virtual void setyWavelength(double yWavelength)
		{
			this.yWavelength = yWavelength;
		}

		public virtual double getxAmplitude()
		{
			return xAmplitude;
		}

		public virtual void setxAmplitude(double xAmplitude)
		{
			this.xAmplitude = xAmplitude;
		}

		public virtual double getyAmplitude()
		{
			return yAmplitude;
		}

		public virtual void setyAmplitude(double yAmplitude)
		{
			this.yAmplitude = yAmplitude;
		}

		protected internal override void transform(int x, int y, double[] t)
		{
			double tx = Math.Sin((double) y / yWavelength + yRandom);
			double ty = Math.Cos((double) x / xWavelength + xRandom);
			t[0] = x + xAmplitude * tx;
			t[1] = y + yAmplitude * ty;
		}

	}

}