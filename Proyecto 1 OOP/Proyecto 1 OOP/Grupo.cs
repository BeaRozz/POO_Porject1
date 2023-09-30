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
                if(name != "")
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Nombre invalido para un grupo");
                }
            }
        }

        public int Size => integrantes.Count;
        
        
        public Grupo(string name)
        {
            Name = name;
        }

        public void Add(string nombre, int edad, string direccion, string numeroDeCuenta, double fondos)
        {
            integrantes.Add(new Persona(integrantes.Count + 1,nombre, edad, direccion, numeroDeCuenta, fondos));
        }
        public string Imprimir()
        {
            string cadena = "";
            foreach(Persona persona in integrantes)
            {
                cadena += $"{persona.GetInfo()}\n";
            }
            return cadena;
        }

        public (bool, Persona) Find(int index)
        {
            int n = integrantes.Count;
            int inf = 0;
            int centro = 0;
            int sup = n - 1;
            while (inf <= sup)
            {
                centro = (sup + inf) / 2;
                if (integrantes[centro].Id == index)
                {
                    return (true, integrantes[centro]);
                }
                else if (index < integrantes[centro].Id)
                {
                    sup = centro - 1;
                }
                else
                {
                    inf = centro + 1;
                }
            }
            return (false, null);

        }
        public (bool, List<Persona>) Find(string nombre)
        {
            nombre = nombre.ToLower();
            List<Persona> parecidos = new List<Persona>();
            foreach (Persona persona in integrantes)
            {
                if (persona.Nombre.ToLower() == nombre)
                {
                    parecidos.Add(persona);
                }
            }

            if(parecidos.Count != 0)
            {
                return (true, parecidos);
            }
            return (false, null);
            
        }
    }
}
