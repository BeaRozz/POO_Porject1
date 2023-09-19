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
        private List<Grupo> grupos = new List<Grupo>();

        public void CrearGrupos()
        {
            WriteLine("¿Cuántos grupos necesita?");
            int groupNumber = int.Parse(ReadLine());
            for (int i = 0; i < groupNumber; i++)
            {
                WriteLine("Ingrese el nombre del grupo");
                grupos.Add(new Grupo(ReadLine()));
            }
        }

        public void Agregar()
        {
            if(grupos.Count != 0)
            {
                WriteLine("¿A que grupo desea agregar elementos?");
                for (int i = 0; i < grupos.Count; i++)
                {
                    WriteLine($"   {i+1}. {grupos[i].Name}");
                }
            }
            
        }
    }
}
