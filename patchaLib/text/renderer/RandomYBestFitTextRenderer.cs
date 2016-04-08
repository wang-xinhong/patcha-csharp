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

	public class RandomYBestFitTextRenderer : AbstractTextRenderer
	{

		protected internal override void arrangeCharacters(int width, int height, TextString ts)
		{
			double widthRemaining = (width - ts.Width - leftMargin - rightMargin) / ts.Characters.Count;
			double vmiddle = height / 2;
			double x = leftMargin + widthRemaining / 2;
			Random r = new Random();
			height -= topMargin + bottomMargin;
			foreach (TextCharacter tc in ts.Characters)
			{
				double heightRemaining = height - tc.Height;
				double y = vmiddle + 0.35 * tc.Ascent + (1 - 2 * r.NextDouble()) * heightRemaining;
				tc.X = x;
				tc.Y = y;
				x += tc.Width + widthRemaining;
			}
		}

	}

}