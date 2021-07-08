using System;

namespace Lib
{
    public class Square : Shape
    {
        public float Side { get; private set; }

        public Square(float side) : base("Cuadrado")
        {
            if (side <= 0)
            {
                throw new Exception("Value of parameter side is not valid. Value must be greater than 0");
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

        public override string Render()
        {
            string render = "";

            //Matriz cuadrada a partir del tamaño de cuadrícula configurado
            for (int x = 0; x < this._quad; x++)
            {
                for (int y = 0; y < this._quad; y++)
                {
                    //Línea pinta puntos en los extremos superior, inferior y laterales de la cuadrícula
                    //Todas las demás celdas están vacías
                    //Pinta punto en todas las celdas si está en la primera o última coordenada X
                    //Pinta punto si está en la primera o última coordenada Y en todas las demás coordenadas X
                    if (y == 0 || y == (this._quad - 1) || x == 0 || x == (this._quad - 1))
                    {
                        render += ". ";
                    }
                    else 
                    {
                        render += "  ";
                    }
                }

                //Para mantener la cuadrícula, al terminar la repetición de las columnas, antes de empezar de una nueva fila se agrega un enter
                render += "\n";
            }

            return render;
        }
    }
}
