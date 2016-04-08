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
	using java.awt.image;
	using ColorFactory = org.patchca.color.ColorFactory;
	using FontFactory = org.patchca.font.FontFactory;

	public interface TextRenderer
	{

		int LeftMargin {set;}

		int RightMargin {set;}

		int TopMargin {set;}

		int BottomMargin {set;}

		void draw(string text, BufferedImage canvas, FontFactory fontFactory, ColorFactory colorFactory);

	}

}