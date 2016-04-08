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

	public class BestFitTextRenderer : AbstractTextRenderer
	{

		protected internal override void arrangeCharacters(int width, int height, TextString ts)
		{
			double widthRemaining = (width - ts.Width - leftMargin - rightMargin) / ts.Characters.Count;
			double x = leftMargin + widthRemaining / 2;
			height -= topMargin + bottomMargin;
			foreach (TextCharacter tc in ts.Characters)
			{
				double y = topMargin + (height + tc.Ascent * 0.7) / 2;
				tc.X = x;
				tc.Y = y;
				x += tc.Width + widthRemaining;
			}
		}

	}

}