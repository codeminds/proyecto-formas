using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("3- Triángulo");
                Console.WriteLine("4- Círculo");
                Console.WriteLine("5- Romboide");
                Console.WriteLine("0- Regresar");

                input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                        if (RenderSquareSubmenu(shapes))
                        {
                            Console.WriteLine("Cuadrado agregado. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        if (RenderRectangleSubmenu(shapes))
                        {
                            Console.WriteLine("Rectángulo agregado. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        if (RenderTriangleSubmenu(shapes))
                        {
                            Console.WriteLine("Triángulo equilátero agregado. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        if (RenderCircleSubmenu(shapes))
                        {
                            Console.WriteLine("Círculo agregado. Presione ENTER para continuar...");
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                        if (RenderRhomboidSubmenu(shapes))
                        {
                            Console.WriteLine("Romboide agregado. Presione ENTER para continuar...");
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
            } while (option != 0);
        }

        private static bool RenderSquareSubmenu(List<Shape> shapes)
        {
            float side;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR CUADRADO");
            Console.WriteLine("================");
            Console.WriteLine();

            Console.Write("Lado (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out side))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (side <= 0)
            {
                Console.WriteLine("Lado no puede ser menor a 1. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Square(side));
            return true;
        }

        private static bool RenderRectangleSubmenu(List<Shape> shapes)
        {
            float sideBase;
            float sideHeight;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR RECTÁNGULO");
            Console.WriteLine("==================");
            Console.WriteLine();

            Console.Write("Base (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out sideBase))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (sideBase <= 0)
            {
                Console.WriteLine("Base no puede ser menor a 1. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            Console.Write("Altura (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out sideHeight))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (sideHeight <= 0)
            {
                Console.WriteLine("Altura no puede ser menor a 1. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (sideHeight == sideBase)
            {
                Console.WriteLine("Base no puede ser igual a altura. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Rectangle(sideBase, sideHeight));
            return true;
        }
        private static bool RenderCircleSubmenu(List<Shape> shapes)
        {
            float radio;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR CÍRCULO");
            Console.WriteLine("===============");
            Console.WriteLine();

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
                Console.WriteLine("Radio no puede ser menor a 1. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Circle(radio));
            return true;
        }
        private static bool RenderTriangleSubmenu(List<Shape> shapes)
        {
            float side;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR TRIÁNGULO EQUILÁTERO");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.Write("Lado (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out side))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (side <= 0)
            {
                Console.WriteLine("Lado no puede ser menor a 1. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Triangle(side));
            return true;
        }

        private static bool RenderRhomboidSubmenu(List<Shape> shapes)
        {
            string input;
            float sideWidth;
            float sideHeight;

            Console.Clear();
            Console.WriteLine("AGREGAR ROMBOIDE");
            Console.WriteLine("================");
            Console.WriteLine();

            Console.Write("Ancho (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out sideWidth))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (sideWidth <= 0)
            {
                Console.WriteLine("Ancho no puede ser menor a 1. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            Console.Write("Alto (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out sideHeight))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (sideHeight <= 0)
            {
                Console.WriteLine("Alto no puede ser menor a 1. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Rhomboid(sideHeight, sideWidth));
            return true;
        }
    }
}
