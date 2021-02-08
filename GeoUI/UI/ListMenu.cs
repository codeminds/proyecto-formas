using GeoLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    class ListMenu
    {
        public static void RenderMenu(List<Shape> shapes)
        {
            int option;
            string input;

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
                    RenderShapeSubMenu(shapes, shapes[option - 1]);
                }
                else if (option != 0)
                {
                    Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                    Console.ReadLine();
                }
            } while (option != 0);
        }

        public static void RenderShapeSubMenu(List<Shape> shapes, Shape shape)
        {
            int option;
            string input;

            do
            {
                Console.Clear();
                Console.WriteLine("FORMA: " + shape.Name.ToUpper());
                Console.WriteLine("==============================");
                Console.WriteLine();

                Console.WriteLine("1- Ver Área");
                Console.WriteLine("2- Ver Perímetro");
                Console.WriteLine("3- Borrar Forma");
                Console.WriteLine("0- Regresar");


                input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("El " + shape.Name + " tiene un área de " + shape.GetArea());
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("El " + shape.Name + " tiene un perímetro de " + shape.GetPerimeter());
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                    case 3:
                        bool valid;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Está seguro que desea borrar esta forma?S/N");
                            input = Console.ReadLine();
                            input = input.ToLower();

                            if (input == "s" || input == "sí" || input == "si")
                            {
                                shapes.Remove(shape);
                                option = 0;
                                valid = true;
                            }
                            else if (input != "n" && input != "no")
                            {
                                Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                                Console.ReadLine();
                                valid = false;
                            }
                            else 
                            {
                                valid = true;
                            }
                        } while (!valid);
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
    }
}
