using System;
using System.Collections.Generic;
using GeoLib;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            string input;
            List<Shape> shapes = new List<Shape>();

            do
            {
                Console.Clear();
                Console.WriteLine("FORMAS GEOMÉTRICAS");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1- Agregar Forma");
                Console.WriteLine("2- Listar Formas");
                Console.WriteLine("0- Salir");

                input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    option = -1;
                }

                try
                {
                    switch (option)
                    {
                        case 1:
                            AddMenu.RenderMenu(shapes);
                            break;
                        case 2:
                            ListMenu.RenderMenu(shapes);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            Console.WriteLine("Presione enter para continuar");
                            Console.ReadLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sucedió un error inesperado");
                    Console.WriteLine("Presione Enter para regresar al menú principal");
                    Console.ReadLine();
                }

            } while (option != 0);
        }
    }
}
