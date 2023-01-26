using System;

namespace ConsoleAppEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //titulo y encabezado
            Console.Title = "sexagesimales a radianes";
            Console.WriteLine("acontinuacion, se calculará los grados sexagesimales para obtener su equivalente en radianes");

            //definicion de las variables
            double GradosSexagesimales;
            double radianes;
            Console.Write("ingrese el valor sexagesimal:");
            GradosSexagesimales = double.Parse(Console.ReadLine());
            
            //proceso
            radianes= GradosSexagesimales * 0.0174532925;

            //final y resultado
            Console.WriteLine($"los Grados sexagesimales equivale a radianes: {radianes}");
            Console.Read();

            
        }
    }
}
