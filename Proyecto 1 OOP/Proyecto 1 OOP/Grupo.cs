using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_OOP
{
    internal class Grupo
    {
        private string name;
        private List<Persona> integrantes = new List<Persona>();

        public string Name
        {
            get => name;

            set
            {
                if(name != " ")
                {
                    name = value;
                }
            }
        }
        
        
        public Grupo(string name)
        {
            Name = name;
        }

        public void Add(string nombre, int edad, string direccion, string numeroDeCuenta, double fondos)
        {
            integrantes.Add(new Persona(integrantes.Count + 1,nombre, edad, direccion, numeroDeCuenta, fondos));
        }

    }
}
