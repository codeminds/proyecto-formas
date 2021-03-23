using System;

namespace Lib
{
    public class Triangle : Shape
    {
        public float Side { get; private set; }
        public float Height { get; private set; }

        public Triangle (float side) : base("Triángulo Equilatero")
        {
            if (side <= 0)
            {
                throw new Exception("Value of paremeter side is not valid. Value must be greater than 0");
            }

            this.Side = side;
            this.Height = (float)Math.Sqrt(Math.Pow(side, 2) - Math.Pow(side /2, 2));

        }

        public override float GetArea()
        {
            return this.Side * this.Height / 2;
        }

        public override float GetPerimeter()
        {
            return this.Side * 3;
        }
    }
}
