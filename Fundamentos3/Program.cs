using System;
using System.Text;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SobreGuids();
            ComparaStrings();
            ComparaStrings2();
            SobreStrings();
            SobreStrings2();
            */
            SobreStrings3();
        }
        static void SobreGuids()
        {
            var id = Guid.NewGuid();
            id.ToString();

            // id = new Guid("ef87911f-3489-444b-80a5-3ed6ca18f055");
            Console.WriteLine(id);
            Console.WriteLine(id.ToString().Substring(0, 8));
        }
        static void SobreStrings()
        {
            var price = 10.2;
            var texto = string.Format("O preço do produto é {0} apenas na promoção. {1}",
            price, true);

            var price2 = 46.72;
            var texto2 = $@"O preço de outro produto é {price2}
            e a promoção é válida";
            // com o @ é possível dar quebra de linha e continuar com a string

            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.WriteLine(texto.Insert(19, "nacional "));
            Console.WriteLine(texto.Remove(26, 7));

        }
        static void SobreStrings2()
        {
            var texto = "   Este texto é um teste ";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.Length);
            Console.WriteLine(texto.Replace("e", "x")); // caseSensitive

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[3]);

            var result = texto.Substring(8, 5);
            Console.WriteLine(result);
            Console.WriteLine(texto.Trim());
        }
        static void SobreStrings3()
        {
            var texto = new StringBuilder();
            texto.Append("Este texto");
            texto.Append(" é um teste com Stringbuilder");
            Console.WriteLine(texto);
        }
        static void ComparaStrings()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine("texto: " + texto);
            Console.WriteLine("");
            Console.WriteLine("Contém:");
            Console.WriteLine("texto: " + texto.Contains("texto"));
            Console.WriteLine("É: " + texto.Contains("É"));
            Console.WriteLine("É (ignorando caseSensitive): " + texto.Contains("É", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("");
            Console.WriteLine("Começa com: ");
            Console.WriteLine("Este: " + texto.StartsWith("Este"));
            Console.WriteLine("este: " + texto.StartsWith("este"));
            Console.WriteLine("este (ignorando caseSensitive): " + texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("");
            Console.WriteLine("Termina com: ");
            Console.WriteLine("teste: " + texto.EndsWith("teste"));
            Console.WriteLine("Teste: " + texto.EndsWith("Teste"));
            Console.WriteLine("Teste (ignorando caseSensitive): " + texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
        }
        static void ComparaStrings2()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}