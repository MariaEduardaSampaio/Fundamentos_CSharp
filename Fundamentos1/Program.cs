// See https://aka.ms/new-console-template for more information
namespace MeuApp // separação lógica do código
{
    class Program
    {
        static void Main(string[] args)
        {
            //, /* */ ou ///

            /* 
            substitui o nome de um tipo
            recomendado o seu uso!! 
            uma vez definido o tipo do que foi atribuido à variavel
            não é possível alterar este tipo posteriormente */
            var texto = "Testando";
            Console.WriteLine(texto);

            uint idade = 41;
            var salario = 2500;
            double salario1 = 2500.92;
            float salario2 = 2500.87f; // deve ter o sufixo f
            decimal salarioAnual = 30000.89m; // deve ter o sufixo m
            bool usuarioCadastrado = true;
            char primeiraLetra = 'A'; // deve ser em aspas simples
            string primeiraFrase = "A"; // deve ser em aspas duplas
            string cpf = "000.000.000-00";
            object quantidade;
            quantidade = 1;
            quantidade = 2.5;
            quantidade = "teste"; // pode assinar qualquer tipo a um dado
            // sem controle sobre o object, não é recomendado

            int? valor = null; // deve ter a interrogação na frente do tipo
            int num1 = 1; // alias
            Int32 num2 = 1; // tipo

            // valor padrao de uma variavel do tipo bool que nao foi informado é false

            // ********* Conversão Implícita **********
            // é possível atribuir um int a um float, mas não o contrário

            // ********* Conversão Explícita **********
            // Ocorre quando os tipos não são compatíveis entre si

            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro;

            // ********* Parse **********
            // usado para converter um caractere ou string para um tipo qualquer
            // caso haja alguma incompatibilidade, gera um erro
            int numero = int.Parse("100");

            // ********* Convert **********
            // permite converter varios tipos de valor, nao apenas string
            // devemos informar o tipo na chamada da conversão

            int numeroConv = Convert.ToInt32("100");
        }
    }
}