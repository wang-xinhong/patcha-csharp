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
namespace org.patchca.text.renderer
{

	public class TextString
	{

		private List<TextCharacter> characters = new List<TextCharacter>();

		public virtual void clear()
		{
			characters.Clear();
		}

		public virtual void addCharacter(TextCharacter tc)
		{
			characters.Add(tc);
		}

		public virtual List<TextCharacter> Characters
		{
			get
			{
				return characters;
			}
		}

		public virtual double Width
		{
			get
			{
				double minx = 0;
				double maxx = 0;
				bool first = true;
				foreach (TextCharacter tc in characters)
				{
					if (first)
					{
						minx = tc.X;
						maxx = tc.X + tc.Width;
						first = false;
					}
					else
					{
						if (minx > tc.X)
						{
							minx = tc.X;
						}
						if (maxx < tc.X + tc.Width)
						{
							maxx = tc.X + tc.Width;
						}
					}
	
				}
				return maxx - minx;
			}
		}

		public virtual double Height
		{
			get
			{
				double miny = 0;
				double maxy = 0;
				bool first = true;
				foreach (TextCharacter tc in characters)
				{
					if (first)
					{
						miny = tc.Y;
						maxy = tc.Y + tc.Height;
						first = false;
					}
					else
					{
						if (miny > tc.Y)
						{
							miny = tc.Y;
						}
						if (maxy < tc.Y + tc.Height)
						{
							maxy = tc.Y + tc.Height;
						}
					}
	
				}
				return maxy - miny;
			}
		}

	}

}