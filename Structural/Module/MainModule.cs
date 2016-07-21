using System;
using Patterns.Creational;

namespace Patterns.Structural.Module
{
    public sealed class MainModule
    {
        // ...

        // ...

        public MainModule getSingleton()
        {
            return SingletonGeneric<MainModule>.Get();
        }

        // ...

        public void prepare()
        {
            //System.WriteLine("console::prepare();");
        }

        public void unprepare()
        {
            //System.WriteLine("console::unprepare();");
        }

        // ...

        public void PrintNewLine()
        {
            Console.WriteLine("");
        }

        public void PrintString(String Value)
        {
            Console.Write(Value);
        }

        public void printInteger(int Value)
        {
            Console.Write(Value);
        }

        public void printBoolean(Boolean Value)
        {
            Console.Write(Value);
        }

        public void ScanNewLine()
        {
            // to-do: ...
        }

        public void ScanString(String Value)
        {
            // to-do: ...
        }

        public void ScanInteger(int Value)
        {
            // to-do: ...
        }

        public void ScanBoolean(Boolean Value)
        {
            // to-do: ...
        }

        // ...
    }
}