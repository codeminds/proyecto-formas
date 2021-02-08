using System;

namespace GeoLib
{
    public class Square : Shape
    {
        public float Side { get; private set; }

        public Square(float side) : base("Cuadrado")
        {
            if (side <= 0)
            {
                throw new Exception("Value of parameter side is not valid. Value must be greater than 0.");
            }

            this.Side = side;
        }

        public override float GetArea()
        {
            return this.Side * this.Side;
        }

        public override float GetPerimeter()
        {
            return this.Side * 4;
        }
    }
}
