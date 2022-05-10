using GeoLib;

namespace GeoUI
{
    internal class ListMenu
    {
        public static void RenderMenu(List<Shape> shapes)
        {
            int option;
            string? input;

            do
            {
                Console.Clear();
                Console.WriteLine("LISTA DE FORMAS");
                Console.WriteLine("===============");
                Console.WriteLine();

                if (shapes.Count > 0)
                {
                    for (int i = 0; i < shapes.Count; i++)
                    {
                        Console.WriteLine((i + 1) + "- " + shapes[i].Name);
                    }
                }
                else
                {
                    Console.WriteLine("== LISTA VACÍA ==");
                }

                Console.WriteLine("0- Regresar");

                input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                if (option > 0 && option <= shapes.Count)
                {
                    RenderShapeSubmenu(shapes, shapes[option - 1]);
                }
                else if (option != 0)
                {
                    Console.WriteLine("Opción no válida. Presione ENTER para continuar...");
                    Console.ReadLine();
                }
            } while (option != 0);
        }

        private static void RenderShapeSubmenu(List<Shape> shapes, Shape shape)
        {
            int option;
            string? input;

            do
            {
                Console.Clear();
                Console.WriteLine("FORMA: " + shape.Name.ToUpper());
                Console.WriteLine("=======" + RenderShapeNameLowerLine(shape.Name.Length));
                Console.WriteLine();

                Console.WriteLine("1- Información");
                Console.WriteLine("2- Borrar");
                Console.WriteLine("0- Regresar");

                input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                        RenderShapeInfoSubmenu(shape);
                        break;
                    case 2:
                        if (RenderShapeDeleteSubmenu(shapes, shape))
                        {
                            Console.WriteLine(shape.Name + " removido. Presione ENTER para continuar...");
                            Console.ReadLine();
                            option = 0;
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

        private static void RenderShapeInfoSubmenu(Shape shape)
        {
            Console.Clear();
            Console.WriteLine(shape.Render());
            Console.WriteLine("Área: " + shape.GetArea());
            Console.WriteLine("Perímetro: " + shape.GetPerimeter());
            Console.WriteLine("Presione ENTER para regresar...");
            Console.ReadLine();
        }

        private static bool RenderShapeDeleteSubmenu(List<Shape> shapes, Shape shape)
        {
            string? input;

            do
            {
                Console.Clear();
                Console.WriteLine("Está seguro que desea borrar esta forma? S/N");
                input = Console.ReadLine()?.ToLower();

                switch (input)
                {
                    case "s":
                    case "si":
                    case "sí":
                        shapes.Remove(shape);
                        return true;
                    case "n":
                    case "no":
                        return false;
                    default:
                        Console.WriteLine("Opción no válida. Presione ENTER para continuar...");
                        Console.ReadLine();
                        break;
                }
            } while (true);
        }

        private static string RenderShapeNameLowerLine(int size)
        {
            string render = "";

            for (int i = 0; i < size; i++)
            {
                render += "=";
            }

            return render;
        }
    }
}
