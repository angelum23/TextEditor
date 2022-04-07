

namespace TextEditor
{
    public static class Menu
    {
        public static int ChooseFunction()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("What do you want to do?\n1 - Open archive\n2 - Edit\n3 - Create a new one\n4 - Delete archive\n5 - Quit\n");
                return short.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static void SwitchFunction(int escolha)
        {
            try
            {
                switch (escolha)
                {
                    case 1:
                        Execution.OpenArchive();
                        break;
                    case 2:
                        Execution.EditArchive();
                        break;
                    case 3:
                        Execution.CreateArchive();
                        break;
                    case 4:
                        Execution.DeleteArchive();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid value");
                        Execution.ReStart();
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Execution.ReStart();
            }
        }
    }
}