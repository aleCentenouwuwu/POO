using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche();
            coche.Nombre = "Auto";
            Console.WriteLine("Ingrese marca del auto");
            coche.Marca = Console.ReadLine();
            Console.WriteLine("Ingrese modelo del auto");
            coche.Modelo = Console.ReadLine();
            Console.WriteLine("Ingrese color del auto");
            coche.Color = Console.ReadLine();
            Console.WriteLine("Ingrese velocidad del auto");
            coche.Velocidad = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            coche.arrancar();
            Console.ReadKey();
            coche.acelerar();
            Console.ReadKey();
            coche.frenar();
            Console.ReadKey();
            
            Console.WriteLine("");
            Console.WriteLine($"Informacion del {coche.Nombre}");
            Console.WriteLine("");
            coche.informacion();
            Console.ReadKey();

        }
    }
}
