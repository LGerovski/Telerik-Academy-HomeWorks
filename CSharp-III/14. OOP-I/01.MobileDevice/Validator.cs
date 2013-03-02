namespace MobileDevice
{
    class Validator
    {
        public static bool ValidatePrice(decimal? price)
        {
            if (price < 0)
            {
                return false;
            }
            else
            {
                return true;   
            }
        }
        public static bool ValidateColors(uint? colors)
        {
            if (colors < 0 || colors > uint.MaxValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidateDisplaySize(double? size)
        {
            if (size <= 0 || size > 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidatePhoneNumber(string number)
        {
            foreach (var item in number)
            {
                if (item < '0' || item > '9')
                {
                    return false;
                }
            }
            if (number.Length < 6 || number.Length > 15)
            {
                return false;
            }
            return true;
        }
        public static bool ValidateDuration(int duration)
        {
            if (duration < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
