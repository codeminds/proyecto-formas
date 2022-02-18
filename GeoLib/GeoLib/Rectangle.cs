namespace GeoLib
{
    public class Rectangle : Shape
    {
        public float Base { get; private set; }
        public float Height { get; private set; }

        public Rectangle(float bas, float height) : base("Rectángulo")
        {
            if (bas <= 0)
            {
                throw new Exception("Value of parameter bas is not valid. Value must be greater than 0");
            }

            if (height <= 0)
            {
                throw new Exception("Value of parameter height is not valid. Value must be greater than 0");
            }

            if (bas == height)
            {
                throw new Exception("Value of parameter height cannot be the same as value of parameter bas");
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

        public override string Render()
        {
            string render = "";
            int height;
            int bas;

            //Orietación del rectángulo
            if (this.Base > this.Height)
            {
                height = this._quad;
                bas = this._quad + ((this._quad + 2) / 2);
            }
            else
            {
                height = this._quad + ((this._quad + 2) / 2);
                bas = this._quad;
            }

            //Matriz rectangular a partir del tamaño de cuadrícula configurado.
            //Base varía con una adición de la cuadrícula + 2 dividida entre 2.
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < bas; y++)
                {
                    //Línea pinta puntos en los extremos superior, inferior y laterales de la cuadrícula
                    //Todas las demás celdas están vacías
                    //Pinta punto en todas las celdas si está en la primera o última coordenada X
                    //Pinta punto si está en la primera o última coordenada Y en todas las coordenadas X
                    if (y == 0 || y == bas - 1 || x == 0 || x == height - 1)
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
