// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String ⬇
            string message = "This is my first message";
            Console.WriteLine(message);

            // Integer
            int number = 40;
            Console.WriteLine("Número Entero: " + number);

            // Double (Float)
            double floating = 6.1;
            Console.WriteLine("Número Flotante: " + floating);

            //  Long Number
            long newLong = 6616156156165156;
            Console.WriteLine("Long Number: " + newLong);

            // Char
            char newChar = 'E';
            Console.WriteLine("Caracter: " + newChar);

            // Booleans
            bool newBoolan = true;
            Console.WriteLine("Boolean: " + newBoolan);

            // Ask and Read 
            Console.WriteLine("Introduce tu nombre: ");
            String texto = Console.ReadLine();

            Console.WriteLine("Tu numbre es: " + texto);

            // Homework Solution

            Console.WriteLine("Introduce un número de punto flotente: ");
            double numero_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otro número de punto flotente: ");
            double numero_2 = double.Parse(Console.ReadLine());

            double suma = numero_1 + numero_2;
            Console.WriteLine("Resultado de la suma: " + suma);

            double resta = numero_1 - numero_2;
            Console.WriteLine("Resultado de la resta: " + resta);

            double multiplicacion = numero_1 * numero_2;
            Console.WriteLine("Resultado de la multiplicacion: " + multiplicacion);

            double division = numero_1 / numero_2;
            Console.WriteLine("Resultado de la division: " + division);

            double residuo = numero_1 % numero_2;
            Console.WriteLine("Resultado de la residuo: " + residuo);
        }
    }
}
