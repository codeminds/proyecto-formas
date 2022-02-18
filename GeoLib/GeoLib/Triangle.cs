namespace GeoLib
{
    public class Triangle : Shape
    {
        public float Side { get; private set; }
        public float Height { get; private set; } 

        public Triangle(float side) : base("Triángulo Equilatero")
        {
            if (side <= 0)
            {
                throw new Exception("Value of parameter side is not valid. Value must be greater than 0");
            }

            this.Side = side;
            this.Height = MathF.Sqrt(MathF.Pow(side, 2) - MathF.Pow(side / 2, 2));
        }
        
        public override float GetArea()
        {
            return (this.Side * this.Height) / 2;
        }

        public override float GetPerimeter()
        {
            return this.Side * 3;
        }

        public override string Render()
        {
            string render = "";

            //Centro siempre será número anterior a tamaño de cuadrícula por cálculo impar
            int center = this._quad - 1;

            //Matriz rectangular a partir del tamaño de cuadrícula configurado.
            //Base varía con una adición de la cuadrícula multiplicada por 2 - 1 para asegurar que siempre sea impar.
            for (int x = 0; x < this._quad; x++)
            {
                //Cuadrícula impar permite tener un punto central para la punta del triángulo
                for (int y = 0; y < this._quad * 2 - 1; y++)
                {
                    //Lógica para la punta del triángulo (primera fila)
                    if (x == 0)
                    {
                        //Punta del triángulo siempre debe estar en el centro de la cuadrícula
                        //Todas las demás celdas de esta línea están vacías
                        //Pinta punto si está en centro de coordenada Y
                        if (y == center)
                        {
                            render += ". ";
                        }
                        else
                        {
                            render += "  ";
                        }
                    }
                    //Lógica para la base del tríangulo (última fila)
                    else if (x == this._quad - 1)
                    {
                        //Base del triángulo pinta puntos de par en par para mantener la forma
                        //Celdas impares de esta línea están vacías
                        //Pinta punto si está en coordenada Y par
                        if (y % 2 == 0)
                        {
                            render += ". ";
                        }
                        else
                        {
                            render += "  ";
                        }
                    }
                    //Lógica para el resto del triángulo
                    else
                    {
                        //Línea pinta de forma diagonal sumando una coordenada Y hacia la derecha desde el centro por cada fila
                        //Línea pinta de forma diagonal restando una coordenada Y hacia la izquierda desde el centro por cada fila
                        //Todas las demás celdas de estas líneas están vacías
                        //Pinta punto si está en coordenada Y igual a centro + X o centro - X
                        if (y == center - x || y == center + x)
                        {
                            render += ". ";
                        }
                        else
                        {
                            render += "  ";
                        }
                    }
                }

                //Para mantener la cuadrícula, al terminar la repetición de las columnas, antes de empezar de una nueva fila se agrega un enter
                render += "\n";
            }

            return render;
        }
    }
}
