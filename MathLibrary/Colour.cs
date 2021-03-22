using System;

namespace MathClasses
{
	#region Colours

	public struct Colour
	{
		public uint colour;

        #region Constructors

        public Colour(byte red = 0, byte green = 0, byte blue = 0, byte alpha = 0)
		{
			//Sets the colour by storing individual bytes in a uint
			colour = (uint)((red << 24) + (green << 16) + (blue << 8) + alpha);
		}

        #endregion

        #region Functions

        #region Set

		//Sets the red component of the colour
        public void SetRed(byte red)
		{
			//Clears the red byte in the uint colour by retaining all other bits using an & operator
			colour = colour & 0x00FFFFFF;

			//Slots the red byte into the colour, by converting it to a uint, shifting the byte into position and comparing them using an | operator
			colour = colour | (uint)(red << 24);
		}

		//Sets the green component of the colour
		public void SetGreen(byte green)
		{
			//Clears the green byte in the uint colour by retaining all other bits using an & operator
			colour = colour & 0xFF00FFFF;

			//Slots the green byte into the colour, by converting it to a uint, shifting the byte into position and comparing them using an | operator
			colour = colour | (uint)(green << 16);
		}

		//Sets the blue component of the colour
		public void SetBlue(byte blue)
		{
			//Clears the blue byte in the uint colour by retaining all other bits using an & operator
			colour = colour & 0xFFFF00FF;

			//Slots the blue byte into the colour, by converting it to a uint, shifting the byte into position and comparing them using an | operator
			colour = colour | (uint)(blue << 8);
		}

		//Sets the alpha component of the colour
		public void SetAlpha(byte alpha)
		{
			//Clears the alpha byte in the uint colour by retaining all other bits using an & operator
			colour = colour & 0xFFFFFF00;

			//Slots the alpha byte into the colour, by converting it to a uint, shifting the byte into position and comparing them using an | operator
			colour = colour | (uint)(alpha);
		}

        #endregion

        #region Get

		//Gets the red component value
        public byte GetRed()
		{
			//Shifts the bits to return the red component value as a byte from the uint
			return (byte)(colour >> 24);
		}

		//Gets the green component value
		public byte GetGreen()
		{
			//Shifts the bits to return the green component value as a byte from the uint
			return (byte)(colour >> 16);
		}

		//Gets the blue component value
		public byte GetBlue()
		{
			//Shifts the bits to return the blue component value as a byte from the uint
			return (byte)(colour >> 8);
		}

		//Gets the alpha component value
		public byte GetAlpha()
		{
			//Shifts the bits to return the alpha component value as a byte from the uint
			return (byte)(colour);
		}

		#endregion

		#endregion
	}

	#endregion
}