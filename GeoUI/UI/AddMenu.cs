using Lib;
using System;
using System.Collections.Generic;

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
                Console.WriteLine("");

                Console.WriteLine("1- Cuadrado");
                Console.WriteLine("2- Rectángulo");
                Console.WriteLine("3- Triangulo");
                Console.WriteLine("4- Círculo");
                Console.WriteLine("0- Regresar");

                input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                        if (RenderAddSquareSubMenu(shapes))
                        {
                            Console.WriteLine("Cuadrado agregado a la lista de formas. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        if (RenderAddRectangleSubMenu(shapes))
                        {
                            Console.WriteLine("Rectángulo agregado a la lista de formas. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        if (RenderAddTriangleSubMenu(shapes))
                        {
                            Console.WriteLine("Triángulo Equilátero agregado a la lista de formas. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        if (RenderAddCircleSubMenu(shapes))
                        {
                            Console.WriteLine("Círculo agregado a la lista de formas. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
            while (option != 0);
        }

        private static bool RenderAddSquareSubMenu(List<Shape> shapes)
        {
            float side;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR CUADRADO");
            Console.WriteLine("================");
            Console.WriteLine("");

            Console.Write("Lados (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out side))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (side <= 0)
            {
                Console.WriteLine("Lado debe ser mayor a 0. Presion ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Square(side));
            return true;
        }

        private static bool RenderAddRectangleSubMenu(List<Shape> shapes)
        {
            float bas;
            float height;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR RECTÁNGULO");
            Console.WriteLine("==================");
            Console.WriteLine("");

            Console.Write("Ancho (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out bas))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (bas <= 0)
            {
                Console.WriteLine("Ancho debe ser mayor a 0. Presion ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            Console.Write("Alto (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out height))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (bas <= 0)
            {
                Console.WriteLine("Alto debe ser mayor a 0. Presion ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Rectangle(bas, height));
            return true;
        }

        private static bool RenderAddTriangleSubMenu(List<Shape> shapes)
        {
            float side;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR TRIÁNGULO EQUILÁTERO");
            Console.WriteLine("============================");
            Console.WriteLine("");

            Console.Write("Lados (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out side))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (side <= 0)
            {
                Console.WriteLine("Lado debe ser mayor a 0. Presion ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Triangle(side));
            return true;
        }

        private static bool RenderAddCircleSubMenu(List<Shape> shapes)
        {
            float radio;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR CÍRCULO");
            Console.WriteLine("===============");
            Console.WriteLine("");

            Console.Write("Radio (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out radio))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (radio <= 0)
            {
                Console.WriteLine("Radio debe ser mayor a 0. Presion ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Circle(radio));
            return true;
        }
    }
}
