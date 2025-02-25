using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite um número");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro número");

            double num2 = Convert.ToDouble(Console.ReadLine());

            double soma = num1 + num2;
            double sub = num1 - num2;
            double mult = num1 * num2;
            double modulo = num1 % num2;

            Console.WriteLine("\n Resultados das Op Aritm");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Sub: {sub}");
            Console.WriteLine($"Multi: {mult}");
            Console.WriteLine($"Modulo:(Resto da divisão) {modulo}");

            //Operações Relacionais

            Console.WriteLine("\n Comparação entre os números");
            Console.WriteLine($"Os números são iguais?{num1 == num2}");
            Console.WriteLine($"Os números são diferentes?{num1 != num2}");
            Console.WriteLine($"O primeiro número é maior?{num1 > num2}");
            Console.WriteLine($"O primeiro número é menor?{num1 < num2}");

            Console.WriteLine("\n Verificação Lógica:");

            bool ambosPositivos = num1>0 || num2>0;
            bool NegativoPositivo = num1<0 || num2<0;     
            bool nenhumNegativo = !(num1<0 || num2<0);

            Console.WriteLine($"Ambos positivos {ambosPositivos}");
            Console.WriteLine($"Ao menos um negativo {NegativoPositivo}");
            Console.WriteLine($"Nenhum número negativo {nenhumNegativo}");

            Console.WriteLine("\n Pressione qualquer tecla para sair");
            
            Console.ReadKey();

        }
            
    }
}
