using GeoLib;

namespace GeoUI
{
    internal class AddMenu
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
                            Console.WriteLine("Triángulo agregado. Presione ENTER para continuar...");
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
                Console.WriteLine("Lado debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Square(side));
            return true;
        }

        private static bool RenderRectangleSubmenu(List<Shape> shapes)
        {
            float bas;
            float height;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR RECTÁNGULO");
            Console.WriteLine("==================");
            Console.WriteLine();

            Console.Write("Base (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out bas))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (bas <= 0)
            {
                Console.WriteLine("Base debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            Console.Write("Altura (cm): ");
            input = Console.ReadLine();

            
            if (!float.TryParse(input, out height))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (height <= 0)
            {
                Console.WriteLine("Altura debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if(bas == height)
            {
                Console.WriteLine("Base no puede ser igual a altura. Presion ENTER para continuar...");
                Console.ReadLine();
                return false;
            }
           
            shapes.Add(new Rectangle(bas, height));
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
                Console.WriteLine("Lado debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Triangle(side));
            return true;
        }

        private static bool RenderCircleSubmenu(List<Shape> shapes)
        {
            float radius;
            string input;

            Console.Clear();
            Console.WriteLine("AGREGAR CÍRCULO");
            Console.WriteLine("===============");
            Console.WriteLine();

            Console.Write("Radio (cm): ");
            input = Console.ReadLine();

            if (!float.TryParse(input, out radius))
            {
                Console.WriteLine("Valor no válido. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            if (radius <= 0)
            {
                Console.WriteLine("Radio debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Circle(radius));
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
                Console.WriteLine("Ancho debe ser mayor a 0. Presione ENTER para continuar...");
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
                Console.WriteLine("Alto debe ser mayor a 0. Presione ENTER para continuar...");
                Console.ReadLine();
                return false;
            }

            shapes.Add(new Rhomboid(sideHeight, sideWidth));
            return true;
        }
    }
}
