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

        public void Agregar(string tipo)
        {

        }
    }
}
