using System;

namespace WDScript
{
    public class Program
    {
        private static readonly List<Action> Todo = new();
        private static readonly Dictionary<string, bool> Flags = new()
        {
            { "PrintCopyRight", true }
        };

        public static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
                ArgResolve(args[i], i, ref i);
            AppendTodo();
            foreach (var action in Todo)
                action.Invoke();
        }

        private static void AppendTodo()
        {
            if (Flags["PrintCopyRight"]) Todo.Add(new Action(() => Copyright()));
        }

        private static void ArgResolve(string arg, int index, ref int i)
        {
            switch (arg)
            {
                case "--no-copyright":
                    Flags["PrintCopyRight"] = false;
                    break;
                case "--":
                    break;
            }
        }

        private static void Copyright()
        {
            Console.WriteLine(
                $"WDScript Interpreter Native\n" +
                $"Copyright © Catrol 2022-present\n" +
                $"All Rights Reserved.\n" +
                $"{Environment.OSVersion}\n" +
                $"{AppDomain.CurrentDomain.BaseDirectory}"
            );
        }
    }
}