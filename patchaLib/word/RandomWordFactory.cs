using System;
using System.Text;

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
namespace org.patchca.word
{

	public class RandomWordFactory : WordFactory
	{

		protected internal string characters;
		protected internal int minLength;
		protected internal int maxLength;

		public virtual string Characters
		{
			set
			{
				this.characters = value;
			}
		}

		public virtual int MinLength
		{
			set
			{
				this.minLength = value;
			}
		}

		public virtual int MaxLength
		{
			set
			{
				this.maxLength = value;
			}
		}

		public RandomWordFactory()
		{
			characters = "absdegkmnopwx23456789";//"absdegkmnopwx234578";
			minLength = 4;
			maxLength = 6;
		}

		public string NextWord
		{
			get
			{
				Random rnd = new Random();
				StringBuilder sb = new StringBuilder();
				int l = minLength + (maxLength > minLength ? rnd.Next(maxLength - minLength) : 0);
				for (int i = 0; i < l; i++)
				{
					int j = rnd.Next(characters.Length);
					sb.Append(characters[j]);
				}
				return sb.ToString();
			}
		}

	}

}