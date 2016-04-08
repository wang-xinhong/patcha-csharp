using java.awt;
using java.awt.font;
using java.text;
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
namespace org.patchca.text.renderer
{


	public class TextCharacter
	{

		private double x;
		private double y;
		private double width;
		private double height;
		private double ascent;
		private double descent;
		private char character;
		private Font font;
		private Color color;

		public virtual double X
		{
			get
			{
				return x;
			}
			set
			{
				this.x = value;
			}
		}


		public virtual double Y
		{
			get
			{
				return y;
			}
			set
			{
				this.y = value;
			}
		}


		public virtual double Width
		{
			get
			{
				return width;
			}
			set
			{
				this.width = value;
			}
		}


		public virtual double Height
		{
			get
			{
				return height;
			}
			set
			{
				this.height = value;
			}
		}


		public virtual char Character
		{
			get
			{
				return character;
			}
			set
			{
				this.character = value;
			}
		}


		public virtual Font Font
		{
			get
			{
				return font;
			}
			set
			{
				this.font = value;
			}
		}


		public virtual Color Color
		{
			get
			{
				return color;
			}
			set
			{
				this.color = value;
			}
		}


		public virtual double Ascent
		{
			get
			{
				return ascent;
			}
			set
			{
				this.ascent = value;
			}
		}


		public virtual double Descent
		{
			get
			{
				return descent;
			}
			set
			{
				this.descent = value;
			}
		}


		public virtual AttributedCharacterIterator iterator()
		{
			AttributedString aString = new AttributedString(Convert.ToString(character));
			aString.addAttribute(TextAttribute.FONT, font, 0, 1);
			return aString.getIterator();
		}

	}

}