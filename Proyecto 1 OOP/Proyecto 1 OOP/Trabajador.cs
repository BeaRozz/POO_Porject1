using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_OOP
{
    internal class Trabajador : Persona
    {
        string departamento;
        public string Departamento { get => departamento; set => departamento = value; }

        public Trabajador(string nombre, int edad, string departamento): base(nombre, edad )
        {
            Departamento = departamento;
        }

        
    }
}
