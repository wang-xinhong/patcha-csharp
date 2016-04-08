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

	public class MarbleImageOp : AbstractTransformImageOp
	{

		internal double scale;
		internal double amount;
		internal double turbulence;
		internal double[] tx;
		internal double[] ty;
		internal double randomX;
		internal double randomY;

		public MarbleImageOp()
		{
			scale = 15;
			amount = 1.1;
			turbulence = 6.2;
			randomX = 256 * new Random(1).NextDouble();
			randomY = 256 * new Random(2).NextDouble();
		}

		public virtual double Scale
		{
			get
			{
				return scale;
			}
			set
			{
				this.scale = value;
			}
		}


		public virtual double Amount
		{
			get
			{
				return amount;
			}
			set
			{
				this.amount = value;
			}
		}


		public virtual double Turbulence
		{
			get
			{
				return turbulence;
			}
			set
			{
				this.turbulence = value;
			}
		}


		protected internal override void init()
		{
			lock (this)
			{
				tx = new double[256];
				ty = new double[256];
				for (int i = 0; i < 256; i++)
				{
					double angle = 2 * Math.PI * i * turbulence / 256;
					tx[i] = amount * Math.Sin(angle);
					ty[i] = amount * Math.Cos(angle);
				}
			}
		}

		protected internal override void transform(int x, int y, double[] t)
		{
			int d = limitByte((int)(127 * (1 + PerlinNoise.noise2D(((double)x) / scale + randomX, ((double)y) / scale + randomY))));
			t[0] = x + tx[d];
			t[1] = y + ty[d];
		}

		protected internal virtual void filter2(int[] inPixels, int[] outPixels, int width, int height)
		{
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					int pixel = limitByte((int)(127 * (1 + PerlinNoise.noise2D(((double)x) / scale + randomX, ((double)y) / scale + randomY))));
					outPixels[x + y * width] = (limitByte((int)255) << 24) | (limitByte((int)pixel) << 16) | (limitByte((int)pixel) << 8) | (limitByte((int)pixel));
				}
			}
		}


	}

}