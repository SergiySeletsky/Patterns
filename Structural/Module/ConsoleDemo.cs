namespace Patterns.Structural.Module
{
    internal class ConsoleDemo
    {
        public static MainModule Console = null;

        public static void prepare()
        {
            Console = Console.getSingleton();

            Console.prepare();
        }

        public static void unprepare()
        {
            Console.unprepare();
        }

        public static void execute()
        {
            Console.PrintString("Hello World");
            Console.PrintNewLine();
            Console.ScanNewLine();
        }

        public static void main()
        {
            prepare();
            //execute(args);
            unprepare();
        }
    }
}