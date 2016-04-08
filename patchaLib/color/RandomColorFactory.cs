using java.awt;
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
namespace org.patchca.color
{


	public class RandomColorFactory : ColorFactory
	{

		private Color min;
		private Color max;
		private Color color;

		public RandomColorFactory()
		{
			min = new Color(20,40,80);
			max = new Color(21,50,140);
		}

		public virtual Color Min
		{
			set
			{
				this.min = value;
			}
		}

		public virtual Color Max
		{
			set
			{
				this.max = value;
			}
		}

		public Color getColor(int index)
		{
			if (color == null)
			{
				Random r = new Random();
				color = new Color(min.getRed() + r.Next((max.getRed() - min.getRed())), min.getGreen() + r.Next((max.getGreen() - min.getGreen())), min.getBlue() + r.Next((max.getBlue() - min.getBlue())));
			}
			return color;
		}

	}

}