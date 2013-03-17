namespace _01.Figures
{
    abstract class Shape
    {
        protected double width;
        protected double height;

        protected Shape(double width, double height)
        {
            Validator.ValidateWH(width, height);
            this.Width = width;
            this.Height = height;
        }
        protected double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                Validator.ValidateSize(value);
                this.width = value;
            }
        }
        protected double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Validator.ValidateSize(value);
                this.height = value;
            }
        }
        public abstract double CalculateSurface();
    }
}
