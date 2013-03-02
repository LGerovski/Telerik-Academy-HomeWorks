using System;

namespace MobileDevice
{
    class Display
    {
        private double? size;
        private uint? colors;

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (Validator.ValidateDisplaySize(value))
                {
                    this.size = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public uint? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (Validator.ValidateColors(value))
                {
                    this.colors = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public Display(double? size, uint? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }
}
