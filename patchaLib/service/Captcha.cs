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
using java.awt.image;

namespace org.patchca.service
{

	public class Captcha
	{

		private string challenge;
		private BufferedImage image;

		public Captcha(string challenge, BufferedImage image)
		{
			this.challenge = challenge;
			this.image = image;
		}

		public virtual string Challenge
		{
			get
			{
				return challenge;
			}
			set
			{
				this.challenge = value;
			}
		}


		public virtual BufferedImage Image
		{
			get
			{
				return image;
			}
			set
			{
				this.image = value;
			}
		}


	}

}