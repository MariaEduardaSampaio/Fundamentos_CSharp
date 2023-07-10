using System;

namespace MeuApp
{
    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3
    }

    struct Cliente
    {
        public string Nome;
        public EEstadoCivil EstadoCivil;

        public Cliente(string nome, EEstadoCivil estadoCivil)
        {
            Nome = nome;
            EstadoCivil = estadoCivil;
        }
    }
    struct Product
    {
        public int Id;
        public float Price;
        public string Name;
        public float PriceInDolar(float dolar)
        {
            return Price * dolar;
        }

        public Product(int id, string name, float price)
        {
            Id = id;
            Price = price;
            Name = name;
        }
    }
    class Program
    {

        static string RetornaNome(string nome, string sobrenome, int idade = 20)
        {
            return nome + " " + sobrenome + " tem " + idade.ToString() + " anos.";
        }
        static void Main(string[] args)
        {
            var cliente = new Cliente("maria", EEstadoCivil.Solteiro);
            Console.WriteLine(cliente.EstadoCivil);
            Console.WriteLine((int)cliente.EstadoCivil);

            var product = new Product(1, "mouse gamer", 128.75f);
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);

            /*
            int inteiro = 100;
            float real = 25.7f;

            inteiro = (int)real;
            Console.WriteLine(inteiro); // simplesmente retirou o que havia de decimal

            int inteiro2 = 1;
            // inteiro2 = int.Parse(real); dá erro pq real é float
            string valorReal = real.ToString();
            inteiro2 = Convert.ToInt32(real); // arredondou para cima
            Console.WriteLine(inteiro2);

            Console.WriteLine(Convert.ToBoolean(1)); 
            // qualquer valor maior q 0 é true
            
            do while checa a condição depois de executar
            */

            Console.WriteLine(RetornaNome("maria", "eduarda"));
        }
    }
}