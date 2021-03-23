using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Rectangle : Shape
    {
        public float Base { get; private set; }
        public float Height { get; private set; }

        public Rectangle(float bas, float height) : base ("Rectángulo")
        {
            if (bas <= 0)
            {
                throw new Exception("Value of paremeter base is not valid. Value must be greater than 0");
            }

            if (height <= 0)
            {
                throw new Exception("Value of paremeter height is not valid. Value must be greater than 0");
            }

            if (height == bas)
            {
                throw new Exception("Value of paremeter height cannot be the same as value of parameter base");
            }

            this.Base = bas;
            this.Height = height;
        }

        public override float GetArea()
        {
            return this.Base * this.Height;
        }

        public override float GetPerimeter()
        {
            return this.Base * 2 + this.Height * 2;
        }
    }
}
