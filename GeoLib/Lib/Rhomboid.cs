using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    //Descartado del proyecto
    public class Rhomboid : Shape
    {
        public float Height { get; private set; }
        public float Width { get; private set; }

        public Rhomboid(float height, float width) : base("Romboide")
        {
            if (height <= 0)
            {
                throw new Exception("Value of parameter height is not valid. Value must be greater than 0");
            }
            if (width <= 0)
            {
                throw new Exception("Value of parameter side is not valid. Value must be greater than 0");
            }

            this.Height = height;
            this.Width = width;
        }
        public override float GetArea()
        {
            return this.Width * this.Height;
        }
        public override float GetPerimeter()
        {
            return (this.Width + this.Height) * 2;
        }

        public override string Render()
        {
            string render = "";
            int bas = this._quad * 3;
            int height = this._quad;
            bool isQuadEven = bas % 2 == 0;

            for (int x = 0; x < height; x++)
            {
                int dotStart = (height - 1) - x;
                int dotEnd = (bas - 1) - (height - (height - x));

                for (int y = 0; y < bas; y++)
                {
                    bool paintDotStart = isQuadEven ? y % 2 != 0 : y % 2 == 0;
                    if ((x == 0 && y > dotStart && paintDotStart) || (x == height - 1 && y < dotEnd && y % 2 == 0))
                    {
                        render += ". ";
                    }
                    else if (y == dotStart || y == dotEnd)
                    {
                        render += ". ";
                    }
                    else
                    { 
                        render += "  ";
                    }
                }

                render += "\n";
            }

            return render;
        }
    }
}
