using GeoLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    class AddMenu
    {
        public static void RenderMenu(List<Shape> shapes)
        {
            int option;
            string input;

            do
            {
                Console.Clear();
                Console.WriteLine("AGREGAR FORMA");
                Console.WriteLine("=============");
                Console.WriteLine();

                Console.WriteLine("1- Cuadrado");
                Console.WriteLine("2- Rectángulo");
                Console.WriteLine("3- Círculo");
                Console.WriteLine("0- Regresar");

                input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                switch (option) 
                {
                    case 1:
                        if (AddSquareSubMenu(shapes)) 
                        {
                            Console.WriteLine("Cuadrado agregado a lista de formas");
                            Console.WriteLine("Presione Enter para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        if (AddRectangleSubMenu(shapes))
                        {
                            Console.WriteLine("Rectángulo agregado a lista de formas");
                            Console.WriteLine("Presione Enter para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        if (AddCircleSubMenu(shapes))
                        {
                            Console.WriteLine("Círculo agregado a lista de formas");
                            Console.WriteLine("Presione Enter para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }

            } while (option != 0);
        }

        public static bool AddSquareSubMenu(List<Shape> shapes)
        {
            float side;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR CUADRADO");
            Console.WriteLine("================");

            Console.Write("Lado (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out side))
            {
                Console.WriteLine("Valor no válido. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            if (side <= 0)
            {
                Console.WriteLine("Lado no puede ser menor a 1. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            } 

            shapes.Add(new Square(side));
            return true;
        }


        public static bool AddRectangleSubMenu(List<Shape> shapes)
        {
            float length;
            float width;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR RECTÁNGULO");
            Console.WriteLine("================");

            Console.Write("Altura (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out length))
            {
                Console.WriteLine("Altura no válida. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            Console.Write("Ancho (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out width))
            {
                Console.WriteLine("Ancho no válido. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            if (length <= 0)
            {
                Console.WriteLine("Altura no puede ser menor a 1. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            if (width <= 0)
            {
                Console.WriteLine("Ancho no puede ser menor a 1. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            if (width == length)
            {
                Console.WriteLine("Ancho y altura no pueden ser iguales. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Rectangle(length, width));
            return true;
        }



        public static bool AddCircleSubMenu(List<Shape> shapes)
        {
            float radio;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR CIRCULO");
            Console.WriteLine("================");

            Console.Write("Radio (cm): ");
            input = Console.ReadLine();


            if (!float.TryParse(input, out radio))
            {
                Console.WriteLine("Valor no válido. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            if (radio <= 0)
            {
                Console.WriteLine("Radio no puede ser menor a 1. Presione Enter para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Circle(radio));
            return true;
        }
    }
}
