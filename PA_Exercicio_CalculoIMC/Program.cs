using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Exercicio_CalculoIMC
{
    class Program
    { 
        static void Main(string[] args)
        {
            double h, p, imc;

            Console.Write("Informe a sua altura em metros: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Informe a seu peso em quilogramas: ");
            p = double.Parse(Console.ReadLine());

            imc = p / (h * h);

            Console.WriteLine("O seu IMC é de " + imc + "kg/m²!");

            Console.ReadKey();
        }
    }
}
