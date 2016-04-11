using java.awt;
using java.util;
using patchaLib.extender;
using System;
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
namespace org.patchca.font
{


	public class RandomFontFactory : FontFactory
	{

		protected internal IList<string> families;
		protected internal int minSize;
		protected internal int maxSize;
		protected internal bool randomStyle;

		public RandomFontFactory()
		{
			families = new List<string>();
			families.Add("Verdana");
			families.Add("Tahoma");
			minSize = 20;
			maxSize = 60;
		}

		public RandomFontFactory(IList<string> families) : this()
		{
			this.families = families;
		}

		public RandomFontFactory(string[] families) : this()
		{
			this.families = Arrays.asList(families).getIList();
		}

		public RandomFontFactory(int size, IList<string> families) : this(families)
		{
			minSize = maxSize = size;
		}

		public RandomFontFactory(int size, string[] families) : this(families)
		{
			minSize = maxSize = size;
		}

		public virtual IList<string> Families
		{
			set
			{
				this.families = value;
			}
		}

		public virtual int MinSize
		{
			set
			{
				this.minSize = value;
			}
		}

		public virtual int MaxSize
		{
			set
			{
				this.maxSize = value;
			}
		}

		public virtual bool RandomStyle
		{
			set
			{
				this.randomStyle = value;
			}
		}

		public Font getFont(int index)
		{
			java.util.Random r = new java.util.Random();
			string family = families[r.nextInt(families.Count)];
			bool bold = r.nextBoolean() && randomStyle;
			int size = minSize;
			if (maxSize - minSize > 0)
			{
				size += r.nextInt(maxSize - minSize);
			}
			return new Font(family, bold ? Font.BOLD : Font.PLAIN, size);
		}

	}

}