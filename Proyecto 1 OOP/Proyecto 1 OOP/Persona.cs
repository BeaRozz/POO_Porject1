using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_OOP
{
    internal class Persona
    {
     
        private string nombre;
        private int edad;
        private string direccion;
        private string numeroCuenta;
        private double fondos;

        public int Id { get; private set; }
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
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            NumeroCuenta = numeroDeCuenta;
            Fondos = fondos;
        }

        public string GetInfo()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Edad: {Edad}, Dirección: {Direccion}, Numero de cuenta: {numeroCuenta}, Fondos: {Fondos}";
        }

        
        
    }
}
