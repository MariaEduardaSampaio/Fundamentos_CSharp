using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char key = 's';

            while (key != 'n')
            {
                Console.Clear();
                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Menu(v1, v2);
                Console.WriteLine("Deseja fazer outra operação? (s/n)");
                key = char.Parse(Console.ReadLine());
            }
        }

        enum EOperacao
        {
            soma = 1,
            subtracao = 2,
            divisao = 3,
            multiplicacao = 4
        }
        static void Menu(float v1, float v2)
        {
            Console.Clear();
            Console.WriteLine("Escolha o tipo de operação que deseja realizar: ");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtracao");
            Console.WriteLine("3. Divisao");
            Console.WriteLine("4. Multiplicação");
            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");
            short operacao = short.Parse(Console.ReadLine());

            switch (operacao)
            {
                case (int)EOperacao.soma:
                    Soma(v1, v2);
                    Console.WriteLine($"O resultado da soma entre {v1} e {v2} é {Soma(v1, v2)}");
                    break;

                case (int)EOperacao.subtracao:
                    Subtracao(v1, v2);
                    Console.WriteLine($"O resultado da subtração entre {v1} e {v2} é {Subtracao(v1, v2)}");
                    break;

                case (int)EOperacao.divisao:
                    Divisao(v1, v2);
                    Console.WriteLine($"O resultado da divisão entre {v1} e {v2} é {Divisao(v1, v2)}");
                    break;

                case (int)EOperacao.multiplicacao:
                    Multiplicacao(v1, v2);
                    Console.WriteLine($"O resultado da multiplicação entre {v1} e {v2} é {Multiplicacao(v1, v2)}");
                    break;

                default:
                    Console.WriteLine("Operação inválida, escolha entre 1 e 4.");
                    break;
            }
        }
        static float Soma(float v1, float v2)
        {
            return v1 + v2;
        }

        static float Subtracao(float v1, float v2)
        {
            return v1 - v2;
        }

        static float Divisao(float v1, float v2)
        {
            return v1 / v2;
        }

        static float Multiplicacao(float v1, float v2)
        {
            return v1 * v2;
        }
    }
}
// ctrl + " = abre terminal