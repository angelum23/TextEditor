namespace TextEditor
{
    public static class Menu
    {
        public static int ExibeMenu()
        {
            try
            {
                Console.WriteLine("O que você deseja fazer?\n1 - Abrir arquivo\n2 - Criar novo arquivo\n3 - Sair\n");
                return short.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}