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
namespace org.patchca.service
{
	using java.awt.image;
	using BackgroundFactory = org.patchca.background.BackgroundFactory;
	using ColorFactory = org.patchca.color.ColorFactory;
	using FilterFactory = org.patchca.filter.FilterFactory;
	using FontFactory = org.patchca.font.FontFactory;
	using TextRenderer = org.patchca.text.renderer.TextRenderer;
	using WordFactory = org.patchca.word.WordFactory;

	public abstract class AbstractCaptchaService : CaptchaService
	{

		protected internal FontFactory fontFactory;
		protected internal WordFactory wordFactory;
		protected internal ColorFactory colorFactory;
		protected internal BackgroundFactory backgroundFactory;
		protected internal TextRenderer textRenderer;
		protected internal FilterFactory filterFactory;
		protected internal int width;
		protected internal int height;

		public virtual FontFactory FontFactory
		{
			set
			{
				this.fontFactory = value;
			}
			get
			{
				return fontFactory;
			}
		}

		public virtual WordFactory WordFactory
		{
			set
			{
				this.wordFactory = value;
			}
			get
			{
				return wordFactory;
			}
		}

		public virtual ColorFactory ColorFactory
		{
			set
			{
				this.colorFactory = value;
			}
			get
			{
				return colorFactory;
			}
		}

		public virtual BackgroundFactory BackgroundFactory
		{
			set
			{
				this.backgroundFactory = value;
			}
			get
			{
				return backgroundFactory;
			}
		}

		public virtual TextRenderer TextRenderer
		{
			set
			{
				this.textRenderer = value;
			}
			get
			{
				return textRenderer;
			}
		}

		public virtual FilterFactory FilterFactory
		{
			set
			{
				this.filterFactory = value;
			}
			get
			{
				return filterFactory;
			}
		}







		public virtual int Width
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

		public virtual int Height
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



		public Captcha Captcha
		{
			get
			{
				BufferedImage bufImage = new BufferedImage(width, height, BufferedImage.TYPE_INT_ARGB);
				backgroundFactory.fillBackground(bufImage);
				string word = wordFactory.NextWord;
				textRenderer.draw(word, bufImage, fontFactory, colorFactory);
				bufImage = filterFactory.applyFilters(bufImage);
				return new Captcha(word, bufImage);
			}
		}

	}

}