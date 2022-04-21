using System;
using System.Globalization;

namespace CalculoSalarioMensal_CSharp_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcionario, horas;
            double valorh;

            Console.WriteLine("Qual o número do Funcionário por favor?");
            funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas de trabalho?");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor por hora trabalhada?");
            valorh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorh;

            Console.WriteLine();
            Console.WriteLine("Resultado:");
            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
