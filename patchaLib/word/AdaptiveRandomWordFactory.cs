using patchaLib.extender;
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

	public class AdaptiveRandomWordFactory : RandomWordFactory
	{

		protected internal string wideCharacters;

		public virtual string WideCharacters
		{
			set
			{
				this.wideCharacters = value;
			}
		}

		public AdaptiveRandomWordFactory()
		{
			characters = "absdegkmnopwx23456789";
			wideCharacters = "mw";
		}

		public string NextWord
		{
			get
			{
				Random rnd = new Random();
				StringBuilder sb = new StringBuilder();
				StringBuilder chars = new StringBuilder(characters);
				int l = minLength + (maxLength > minLength ? rnd.Next(maxLength - minLength) : 0);
				for (int i = 0; i < l; i++)
				{
					int j = rnd.Next(chars.Length);
					char c = chars[j];
					if (wideCharacters.IndexOf(c) != -1)
					{
						for (int k = 0; k < wideCharacters.Length; k++)
						{
							int idx = chars.IndexOf(Convert.ToString(wideCharacters[k]));
							if (idx != -1)
							{
								chars.Remove(idx, 1);
							}
						}
					}
					sb.Append(c);
				}
				return sb.ToString();
			}
		}

	}

}