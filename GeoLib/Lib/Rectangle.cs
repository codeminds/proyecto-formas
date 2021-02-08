using System;

namespace GeoLib
{
    public class Rectangle : Shape
    {
        public float Length { get; private set; }
        public float Width { get; private set; }

        public Rectangle(float length, float width) : base("Rectángulo")
        {
            if (length <= 0 || width <= 0)
            {
                throw new Exception("Value of parameters length/side are not valid. Values must be greater than 0.");
            }

            if (length == width)
            {
                throw new Exception("Value of parameters length/side are not valid. Values can't be equal.");
            }

            this.Length = length;
            this.Width = width;
        }

        public override float GetArea()
        {
            return this.Length * this.Width;
        }

        public override float GetPerimeter()
        {
            return 2 * (this.Length + this.Width);
        }
    }
}
