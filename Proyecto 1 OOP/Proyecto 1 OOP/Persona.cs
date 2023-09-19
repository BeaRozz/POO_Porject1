using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_OOP
{
    internal class Persona
    {
        private int id; 
        private string nombre;
        private int edad;
        private string direccion;
        private string numeroCuenta;
        private double fondos;

        public int Id { get => id;}
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; 
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("La edad debe ser mayor a 0");

                edad = value;
            } 
        }
        public string Direccion { get => direccion; set => direccion = value; }
        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public double Fondos
        {
            get => fondos;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El número debe ser igual o mayor que 0");
                
                fondos = value;

            }
        }


        public Persona(int id, string nombre, int edad, string direccion, string numeroDeCuenta, double fondos)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            NumeroCuenta = numeroDeCuenta;
            Fondos = fondos;
        }


        
    }
}
