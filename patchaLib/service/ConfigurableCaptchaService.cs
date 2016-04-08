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

	using SingleColorBackgroundFactory = org.patchca.background.SingleColorBackgroundFactory;
	using SingleColorFactory = org.patchca.color.SingleColorFactory;
	using CurvesRippleFilterFactory = org.patchca.filter.predefined.CurvesRippleFilterFactory;
	using RandomFontFactory = org.patchca.font.RandomFontFactory;
	using BestFitTextRenderer = org.patchca.text.renderer.BestFitTextRenderer;
	using AdaptiveRandomWordFactory = org.patchca.word.AdaptiveRandomWordFactory;

	public class ConfigurableCaptchaService : AbstractCaptchaService
	{

		public ConfigurableCaptchaService()
		{
			backgroundFactory = new SingleColorBackgroundFactory();
			wordFactory = new AdaptiveRandomWordFactory();
			fontFactory = new RandomFontFactory();
			textRenderer = new BestFitTextRenderer();
			colorFactory = new SingleColorFactory();
			filterFactory = new CurvesRippleFilterFactory(colorFactory);
			textRenderer.LeftMargin = 10;
			textRenderer.RightMargin = 10;
			width = 160;
			height = 70;
		}

	}

}