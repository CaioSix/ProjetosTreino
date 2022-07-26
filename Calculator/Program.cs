using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual Operacao gostaria de fazer:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("==============");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            double v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor");
            double v2 = Int16.Parse(Console.ReadLine());
            double soma = v1 + v2;

            Console.WriteLine($"o primeiro valor digitado foi {v1} e o segundo foi {v2}");
            Console.WriteLine($"A soma dos valores é {soma}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            double v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor");
            double v2 = Int32.Parse(Console.ReadLine());
            double subtracao = v1 - v2;

            Console.WriteLine($"o primeiro valor digitado foi {v1} e o segundo foi {v2}");
            Console.WriteLine($"A soma dos valores é {subtracao}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro Valor");
            double v1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor Valor");
            double v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            double resultado = v1 * v2;
            Console.WriteLine($"O valor da divisao de {v1} e {v2} é de {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro Valor");
            double v1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor Valor");
            double v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            double resultado = v1 * v2;
            Console.WriteLine($"O valor da multiplicacao é  de {v1} e {v2} é de {resultado}");
            Console.ReadKey();
            Menu();
        }


    }
}







