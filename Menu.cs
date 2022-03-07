using TextEditor;

namespace TextEditor
{
    public static class Menu
    {
        public static int ChooseFunction()
        {
            try
            {
                Console.WriteLine("What do you want to do?\n1 - Open archive\n2 - Create a new one\n3 - Quit\n");
                return short.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static void SwitchFunction(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    Execution.OpenArchive();
                    break;
                case 2:
                    Execution.CreateArchive();
                    break;
                case 3:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid value");
                    break;

            }
        }
    }
}