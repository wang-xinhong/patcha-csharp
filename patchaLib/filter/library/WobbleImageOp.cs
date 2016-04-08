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


	public class WobbleImageOp : AbstractTransformImageOp
	{

		private double xWavelength;
		private double yWavelength;
		private double xAmplitude;
		private double yAmplitude;
		private double xRandom;
		private double yRandom;
		private double xScale;
		private double yScale;

		public WobbleImageOp()
		{
			xWavelength = 15;
			yWavelength = 15;
			xAmplitude = 4.0;
			yAmplitude = 3.0;
			xScale = 1.0;
			yScale = 1.0;
			xRandom = 3 * new Random(1).NextDouble();
			yRandom = 10 * new Random(2).NextDouble();
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

		public virtual double getxScale()
		{
			return xScale;
		}

		public virtual void setxScale(double xScale)
		{
			this.xScale = xScale;
		}

		public virtual double getyScale()
		{
			return yScale;
		}

		public virtual void setyScale(double yScale)
		{
			this.yScale = yScale;
		}

		protected internal override void transform(int x, int y, double[] t)
		{
			double tx = Math.Cos((double)(xScale * x + y) / xWavelength + xRandom);
			double ty = Math.Sin((double)(yScale * y + x) / yWavelength + yRandom);
			t[0] = x + xAmplitude * tx;
			t[1] = y + yAmplitude * ty;

		}

	}

}