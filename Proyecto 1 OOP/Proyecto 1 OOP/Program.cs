using Proyecto_1_OOP;
using static System.Console;
internal class Program
{
    static List<Grupo> grupos = new List<Grupo>();
    private static void Main(string[] args)
    {
        int opcion;
        CrearGrupos();

        do
        {
            WriteLine("Elija una opción \n 1. Agregar \n 2. Eliminar \n 3. Buscar \n 4. Editar \n 5. Imprimir \n 6. Salir");
            opcion = int.Parse(ReadLine());
            switch (opcion)
            {
                case 1:
                    Agregar();
                    break;

                case 5:
                 
                    WriteLine("¿Desea imprimir un grupo en específico o todos los grupos? \n    1. Todos los grupos \n    2. Un grupo");
                    int opcionGr = int.Parse(ReadLine());
                    if (opcionGr == 1)
                    {
                        Imprimir();
                    }
                    else if (opcionGr == 2)
                    {
                        WriteLine("¿Qué grupo desea imprimir?");
                        GetGroups();
                        int grupo = int.Parse(ReadLine());
                        Imprimir(grupo-1);
                    }
                    break;

                default:
                    WriteLine("Opción inválida");
                    break;
            }

        } while (opcion != 6);

    }

     static void CrearGrupos()
     {
        WriteLine("¿Cuántos grupos necesita?");
        int groupNumber = int.Parse(ReadLine());
        for (int i = 0; i < groupNumber; i++)
        {
            WriteLine("Ingrese el nombre del grupo: " + (i + 1));
            grupos.Add(new Grupo(ReadLine()));
        }
    }

    static void GetGroups()
    {
        for (int i = 0; i < grupos.Count; i++)
        {
            WriteLine($"   {i + 1}. {grupos[i].Name}");
        }
    }

    static void Agregar()
    {
        if (grupos.Count != 0)
        {
            WriteLine("¿A que grupo desea agregar elementos?");

            GetGroups();

            int opcion = int.Parse(ReadLine());
            if (opcion > 0 && opcion <= grupos.Count)
            {
                WriteLine("Escriba el nombre del cliente ");
                string nombre = ReadLine();
                WriteLine("\nEscriba la edad del cliente");
                int edad = int.Parse(ReadLine());
                WriteLine("\nEscriba la direccion del cliente");
                string direccion = ReadLine();
                // Curp, cvv, fecha de vencimiento, 
                WriteLine("\nEscriba el numero de cuenta del cliente");
                string cuenta = ReadLine();
                WriteLine("\nEscriba la cantidad de dinero del cliente");
                double fondos = double.Parse(ReadLine());
                grupos[opcion-1].Add(nombre, edad, direccion, cuenta, fondos);
                WriteLine("Persona agregada");
                return;
            }
            WriteLine("Número de grupo erróneo");
        }

    }

    static void Imprimir()
    {
        for (int i = 0; i < grupos.Count; i++)
        {
            WriteLine($"{grupos[i].Name}------------------------------------------");
            if (grupos[i].Size >0)
            {
                WriteLine(grupos[i].Imprimir());
                WriteLine();
                continue;
            }
            WriteLine("Grupo vacío");
            WriteLine();

        }
    }
    static void Imprimir(int i)
    {
        WriteLine($"{grupos[i].Name}------------------------------------------");
        if (grupos[i].Size > 0)
        {
            WriteLine(grupos[i].Imprimir());
            WriteLine();
            return;
        }
        WriteLine("Grupo vacío");
        WriteLine();
    }
}
