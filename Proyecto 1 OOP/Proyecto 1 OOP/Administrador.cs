using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Proyecto_1_OOP
{
    internal class Administrador
    {
        //saxofon
        private List<Grupo> grupos = new List<Grupo>();



        public void CrearGrupos()
        {
            WriteLine("¿Cuántos grupos necesita?");
            int groupNumber = int.Parse(ReadLine());
            for (int i = 0; i < groupNumber; i++)
            {
                WriteLine("Ingrese el nombre del grupo: " + (i + 1));
                grupos.Add(new Grupo(ReadLine()));
            }
        }
        public void GetGroups()
        {
            for (int i = 0; i < grupos.Count; i++)
            {
                WriteLine($"   {i + 1}. {grupos[i].Name}");
            }
        }

        public void Agregar()
        {
            if(grupos.Count != 0)
            {
                WriteLine("¿A que grupo desea agregar elementos?");

                GetGroups();

                int opcion = int.Parse(ReadLine());
                if(opcion > 0 && opcion <= grupos.Count)
                {
                    WriteLine("Escriba el nombre del cliente ");
                    string nombre = ReadLine();
                    WriteLine("\nEscriba la edad del cliente");
                    int edad = int.Parse(ReadLine());
                    WriteLine("\nEscriba la direccion del cliente");
                    string direccion = ReadLine();
                    WriteLine("\nEscriba el numero de cuenta del cliente");
                    string cuenta = ReadLine();
                    WriteLine("\nEscriba la cantidad de dinero del cliente");
                    double fondos = double.Parse(ReadLine());
                    grupos[0].Add(nombre, edad, direccion, cuenta, fondos);
                    WriteLine("Producto agregado");
                    return;
                }
                WriteLine("Número de grupo erróneo");
            }
            
        }

        public void Imprimir()
        {

        }
        public void Imprimir(int i)
        {

        }
    }
}
