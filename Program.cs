using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsNumeroCastellano
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("NUMERO EN CASTELLANO MOSTRAR EN NUMERICO");
            Console.WriteLine("Ingrese numero en castellano: ");
            numero = Console.ReadLine();
            switch (numero.ToUpper())  // para q me convierta todo a mayuscula ToUpper
            { 
                case "UNO":
                    Console.WriteLine("1");
                    break;
                case "DOS":
                    Console.WriteLine("2");
                    break;
                case "TRES":
                    Console.WriteLine("3");
                    break;
                case "CUATRO":
                    Console.WriteLine("4");
                    break;
                case "CINCO":
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("numero fuera de rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
