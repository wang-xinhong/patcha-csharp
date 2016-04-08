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
	using java.awt;
	using java.awt.font;
	using java.awt.geom;
	using java.awt.image;
	using ColorFactory = org.patchca.color.ColorFactory;
	using FontFactory = org.patchca.font.FontFactory;


	public abstract class AbstractTextRenderer : TextRenderer
	{

		protected internal int leftMargin;
		protected internal int rightMargin;
		protected internal int topMargin;
		protected internal int bottomMargin;

		protected internal abstract void arrangeCharacters(int width, int height, TextString ts);

		public AbstractTextRenderer()
		{
			leftMargin = rightMargin = 5;
			topMargin = bottomMargin = 5;
		}

		public int LeftMargin
		{
			set
			{
				this.leftMargin = value;
			}
		}

		public int RightMargin
		{
			set
			{
				this.rightMargin = value;
			}
		}

		public int TopMargin
		{
			set
			{
				this.topMargin = value;
			}
		}

		public int BottomMargin
		{
			set
			{
				this.bottomMargin = value;
			}
		}

		public void draw(string text, BufferedImage canvas, FontFactory fontFactory, ColorFactory colorFactory)
		{
			Graphics2D g = (Graphics2D) canvas.getGraphics();
			TextString ts = convertToCharacters(text, g, fontFactory, colorFactory);
			arrangeCharacters(canvas.getWidth(), canvas.getHeight(), ts);
			g.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);
			g.setRenderingHint(RenderingHints.KEY_FRACTIONALMETRICS, RenderingHints.VALUE_FRACTIONALMETRICS_ON);
			g.setRenderingHint(RenderingHints.KEY_RENDERING, RenderingHints.VALUE_RENDER_QUALITY);
			foreach (TextCharacter tc in ts.Characters)
			{
				g.setColor( tc.Color);
				g.drawString(tc.iterator(), (float) tc.X, (float) tc.Y);
			}
		}

		protected internal virtual TextString convertToCharacters(string text, Graphics2D g, FontFactory fontFactory, ColorFactory colorFactory)
		{
			TextString characters = new TextString();
			FontRenderContext frc = g.getFontRenderContext();
			double lastx = 0;
			for (int i = 0; i < text.Length; i++)
			{
				Font font = fontFactory.getFont(i);
				char c = text[i];
				FontMetrics fm = g.getFontMetrics(font);
				Rectangle2D bounds = font.getStringBounds(Convert.ToString(c), frc);
				TextCharacter tc = new TextCharacter();
				tc.Character = c;
				tc.Font = font;
				tc.Width = fm.charWidth(c);
				tc.Height = fm.getAscent() + fm.getDescent();
				tc.Ascent = fm.getAscent();
				tc.Descent = fm.getDescent();
				tc.X = lastx;
				tc.Y = 0;
				tc.Font = font;
				tc.Color = colorFactory.getColor(i);
				lastx += bounds.getWidth();
				characters.addCharacter(tc);
			}
			return characters;
		}

	}

}