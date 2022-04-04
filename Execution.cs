

namespace TextEditor
{
	public static class Execution
	{
		public static void CreateArchive()
        {

        }

        public static void EditArchive()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC para sair)\n");
            string text = "";

            do
            {
                text += (Console.ReadLine() ?? "");
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        private static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo salvo com sucesso no caminho {path}");

            Menu.ChooseFunction();
        }

        public static void OpenArchive()
        {

        }
    }
}

