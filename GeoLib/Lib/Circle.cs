using System;

namespace Lib
{
    public class Circle : Shape
    {
        public float Radio { get; private set; }
        public float Diameter { get; private set; }

        public Circle(float radio) : base("Círculo") 
        {
            if (radio <= 0)
            {
                throw new Exception("Value of parameter radio is not valid. Value must be greater than 0");
            }

            this.Radio = radio;
            this.Diameter = radio * 2;
        }

        public override float GetArea()
        {
            return MathF.PI * MathF.Pow(this.Radio, 2);
        }

        public override float GetPerimeter()
        {
            return MathF.PI * this.Diameter;
        }

        public override string Render()
        {
            string render = "";

            //Espacio alrededor de la cuadrícula para mantener la forma de círculo
            //Valor 7 escogido como factor exponencial para cuadrículas crecientes
            int spacer = (int)MathF.Floor(this._quad / 7) + 1;

            //Matriz cuadrada a partir del tamaño de cuadrícula configurado
            for (int x = 0; x < this._quad; x++)
            {
                for (int y = 0; y < this._quad; y++)
                {
                    //Lógica para la extremos superior e inferior (primera y última fila)
                    if (x == 0 || x == this._quad - 1)
                    {
                        //Extremo deja espacios en blanco acorde al espaciador calculado para la matriz
                        //Rango central se calcula a partir del tamaño de la cuadrícula y cálculo de espaciadores
                        //Extremo pinta puntos en celdas dentro de rango central
                        //Pinta punto si coordenada Y está dentro de rango entre espaciador y (cuadrícula - espaciador)
                        if (y >= spacer && y < this._quad - spacer)
                        {
                            render += ". ";
                        }
                        else
                        {
                            render += "  ";
                        }
                    }
                    //Lógica para líneas diagonales superiores para formar curva de círculo (filas menores a espaciador)
                    else if (x < spacer)
                    {
                        //Línea pinta de forma diagonal sumando una coordenada Y hacia la derecha a partir de punto de espaciador por cada fila
                        //Línea pinta de forma diagonal restando una coordenada Y hacia la izquierda a partir de punto de espaciador por cada fila
                        //Todas las demás celdas de estas líneas están vacías
                        //Pinta punto si está en coordenada Y igual a espaciador - X o ((cuadrícula - 1) - espaciador) + X
                        if (y == spacer - x || y == ((this._quad - 1) - spacer) + x)
                        {
                            render += ". ";
                        }
                        else
                        {
                            render += "  ";
                        }
                    }
                    //Lógica para líneas diagonales inferiores para formar curva de círculo (filas mayores a (cuadrícula - 1) - espaciador)
                    else if (x > (this._quad - 1) - spacer)
                    {
                        //Línea pinta de forma diagonal sumando una coordenada Y hacia la derecha a partir de punto de espaciador por cada fila
                        //Línea pinta de forma diagonal restando una coordenada Y hacia la izquierda a partir de punto de espaciador por cada fila
                        //Cálculo de espaciador y fila restando de la cuadrícula - 1, la fila para quedar con el equivalente paralelo a lógica de diagonales superiores
                        //Todas las demás celdas  de estas líneas están vacías
                        //Pinta punto si está en coordenada Y igual a espaciador - ((cuadrícula - 1) - X) o ((cuadrícula - 1) - espaciador) + ((cuadrícula - 1) - X)
                        if (y == spacer - ((this._quad - 1) - x) || y == ((this._quad - 1) - spacer) + ((this._quad - 1) - x))
                        {
                            render += ". ";
                        }
                        else
                        {
                            render += "  ";
                        }
                    }
                    //Lógica para la extremos laterales (filas que no son diagonales ni extremos superiores)
                    else
                    {
                        //Extremo pinta punto en columna inicial y final
                        //Todas las demás celdas de estas líneas están vacías
                        //Pinta punto si coordenada Y es 0 o (cuadrícula - 1)
                        if (y == 0 || y == this._quad - 1)
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
