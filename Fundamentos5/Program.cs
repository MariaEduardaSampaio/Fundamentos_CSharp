using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        public struct Funcionario
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            /*
            Moedas();
            Arrays();
            */
            Excecoes();
        }

        static void Excecoes()
        {
            /*            
            var arr = new int[3];
            try
            {
                for (var index = 0; index <= 3; index++)
                    Console.WriteLine(arr[index]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Índice não encontrado.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ops, algo deu errado! Tente novamente mais tarde.");
            }
            */
            try
            {
                Salvar("");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }
        private static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                // throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
                throw new MyException(DateTime.Now);
            }
            else
                Console.WriteLine("Texto salvo.");
        }

        static void Arrays()
        {
            var meuArray = new int[5];

            var clone = meuArray.Clone();
            // é reference type, o que altera em um, altera em outro
            var funcionarios = new Funcionario[3];
            funcionarios[0].Id = 0; funcionarios[0].Name = "João";
            funcionarios[1].Id = 1; funcionarios[1].Name = "Josué";
            funcionarios[2].Id = 2; funcionarios[2].Name = "Maria";

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id + ":" + funcionario.Name);
            }

            foreach (var item in meuArray)
                Console.WriteLine(item);



        }

        static void Moedas()
        {
            decimal valor = 10568.25m;

            Console.WriteLine(valor.ToString(
                CultureInfo.CreateSpecificCulture("pt-BR")
            ));

            Console.WriteLine(valor.ToString(
                CultureInfo.CreateSpecificCulture("en-US")
            ));

            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")
            ));

            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Floor(valor));
        }
    }

    public class MyException : Exception
    {
        public MyException(DateTime date)
        {
            QuandoAconteceu = date;
        }
        public DateTime QuandoAconteceu { get; set; }

    }
}