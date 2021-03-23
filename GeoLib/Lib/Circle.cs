using System;

namespace Lib
{
    public class Circle : Shape
    {
        public float Radio { get; private set; }
        public float Diameter { get; private set; }

        public Circle(float radio) : base ("Círculo")
        {
            if (radio <= 0)
            {
                throw new Exception("Value of paremeter radio is not valid. Value must be greater than 0");
            }

            this.Radio = radio;
            this.Diameter = radio * 2;
        }

        public override float GetArea()
        {
            return (float)(Math.PI * Math.Pow(this.Radio, 2));
        }

        public override float GetPerimeter()
        {
            return (float)(Math.PI * this.Diameter);
        }
    }
}
