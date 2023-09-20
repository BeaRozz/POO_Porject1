using Proyecto_1_OOP;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        Administrador administrador = new Administrador();
        administrador.CrearGrupos();
        do
        {
            WriteLine("Elija una opción \n 1. Agregar \n 2. Eliminar \n 3. Buscar \n 4. Editar \n 5. Imprimir \n 6. Salir");
            opcion = int.Parse(ReadLine());
            switch (opcion)
            {
                case 1:
                    administrador.Agregar();
                    break;
                    
                case 5:
                    WriteLine("¿Desea imprimir un grupo en específico o todos los grupos? \n    1. Todos los grupos \n    2. Un grupo");
                    int opcionGr = int.Parse(ReadLine());
                    if(opcionGr == 1)
                    {
                        administrador.Imprimir();
                    }
                    else if(opcionGr == 2)
                    {
                        WriteLine("¿Qué grupo desea imprimir?");
                        administrador.GetGroups();
                        int grupo = int.Parse(ReadLine());
                        administrador.Imprimir(grupo);
                    }
                    break;

                default:
                    break;
            }

        } while (opcion != 6);
    }
}