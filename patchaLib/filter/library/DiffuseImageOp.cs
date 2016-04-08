using patchaLib.extender;
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

	public class DiffuseImageOp : AbstractTransformImageOp
	{

		internal double[] tx;
		internal double[] ty;
		internal double amount;

		public DiffuseImageOp()
		{
			amount = 1.6;
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


		protected internal override void init()
		{
			lock (this)
			{
				tx = new double[256];
				ty = new double[256];
				for (int i = 0; i < 256; i++)
				{
					double angle = 2 * Math.PI * i / 256;
					tx[i] = amount * Math.Sin(angle);
					ty[i] = amount * Math.Cos(angle);
				}
			}
		}

		protected internal override void transform(int x, int y, double[] t)
		{
			Random r = new Random();
			int angle = (int)(r.nextFloat() * 255);
			t[0] = x + tx[angle];
			t[1] = y + ty[angle];
		}

	}

}