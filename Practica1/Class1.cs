using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Animal
    {
        string Name;
        int Guapura;

        public void correr()
        {
            Console.WriteLine("Wasa");
        }
    }
    class Coche
    {
        public string Nombre;
        public string Marca;
        public string Modelo;
        public string Color;
        public double Velocidad;

        public void arrancar()
        {
            Console.WriteLine($"El {Nombre} {Marca} esta arrancando");
        }
        public void acelerar()
        {
            Console.WriteLine($"El {Nombre} {Marca} esta acelerando");
        }
        public void frenar()
        {
            Console.WriteLine($"El {Nombre} {Marca} esta frenando");
        }
        public void informacion()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Velocidad: " + Velocidad);
        }
        class persona
        {
            public string Nombre;
            public int edad;
            public double altura;
            public double peso;
        }
        public void presentacion()
        {

        }
        public void cumpleanos()
        {

        }
        public void info()
        {

        }
    }
}
