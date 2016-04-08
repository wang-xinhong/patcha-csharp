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
namespace org.patchca.utils.encoder
{
	using java.io;
	using javax.imageio;
	using Captcha = org.patchca.service.Captcha;
	using CaptchaService = org.patchca.service.CaptchaService;


	public class EncoderHelper
	{

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static String getChallangeAndWriteImage(org.patchca.service.CaptchaService service, String format, java.io.OutputStream os) throws java.io.IOException
		public static string getChallangeAndWriteImage(CaptchaService service, string format, OutputStream os)
		{
			Captcha captcha = service.Captcha;
			ImageIO.write(captcha.Image, format, os);
			return captcha.Challenge;
		}

	}


}