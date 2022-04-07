namespace TextEditor
{
	public static class Execution
	{
		public static void CreateArchive()
        {
            Console.Clear();
            Console.WriteLine("Write the path where the file will be created: ");
            string path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write("");
            }
            Console.WriteLine($"Empty archive has been created sucessfully {path}");

            ReStart();
        }

        public static void EditArchive()
        {
            Console.Clear();
            Console.WriteLine("Write your text below: (ESC to stop)\n");
            string text = "";

            do
            {
                text += (Console.ReadLine() ?? "");
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        private static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Write the path to save the file: ");
            string path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File saved sucessfully in the path {path}");

            ReStart();
        }

        public static void DeleteArchive()
        {
            Console.Clear();
            Console.WriteLine("Write the path of the file: ");
            string path = Console.ReadLine();
            try
            {
                File.Delete(path);
                Console.WriteLine("File deleted sucessfuly!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error excluding archive: {e}");
            }

            ReStart();
        }

        public static void OpenArchive()
        {
            Console.Clear();
            Console.WriteLine("Write the path of the file: ");
            string path = Console.ReadLine();
            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd(); 
                Console.WriteLine(text);
            }

            ReStart();
        }

        public static void ReStart()
        {
            Console.ReadKey();

            Program.Start();
        }
    }
}

