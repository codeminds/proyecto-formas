using GeoLib;
using GeoUI;

int option;
string? input;
List<Shape> shapes = new List<Shape>();

do
{
    Console.Clear();
    Console.WriteLine("FORMAS GEOMÉTRICAS");
    Console.WriteLine("==================");
    Console.WriteLine();

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
                Console.WriteLine("Opción no válida. Presione ENTER para continuar...");
                Console.ReadLine();
                break;
        }
    }
    catch (Exception)
    {
        //Loggear error
        Console.WriteLine("Error inesperado. Presione ENTER para regresar al menú principal...");
        Console.ReadLine();
    }

} while (option != 0);