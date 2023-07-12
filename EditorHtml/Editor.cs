using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-------------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-------------");
            Console.WriteLine(" Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());

            var option = char.Parse(Console.ReadLine());
            if (option == 's')
                Save(file);

        }

        public static void Save(StringBuilder text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo? (s/n)");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Thread.Sleep(5000);
        }
    }
}