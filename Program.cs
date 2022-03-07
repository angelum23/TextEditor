using TextEditor;

namespace TextEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Menu.SwitchFunction(Menu.ChooseFunction());
        }
    }
}