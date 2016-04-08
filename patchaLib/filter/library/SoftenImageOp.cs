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
namespace org.patchca.filter.library
{

	public class SoftenImageOp : AbstractConvolveImageOp
	{

		private static readonly float[][] matrix = new float[][] {new float[] {0 / 16f, 1 / 16f, 0 / 16f}, new float[] {1 / 16f, 12 / 16f, 1 / 16f}, new float[] {0 / 16f, 1 / 16f, 0 / 16f}};

		public SoftenImageOp() : base(matrix)
		{
		}

	}

}