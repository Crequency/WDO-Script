using System;

namespace WDOScript
{
    public class Program
    {
        /// <summary>
        /// 待办列表
        /// </summary>
        private static readonly List<Action> Todo = new();

        /// <summary>
        /// 标记字典
        /// </summary>
        private static readonly Dictionary<string, bool> Flags = new()
        {
            { "PrintCopyRight", true },             //  是否打印版权信息
            { "EchoOn", true },                     //  是否显示前导符
            { "ErrStartupArgs", false },            //  启动参数是否错误
        };

        /// <summary>
        /// 值字典
        /// </summary>
        private static readonly Dictionary<string, string> Values = new()
        {
            { "SeparateStrLength", "100" },         //  分隔字符串长度
            { "ErrStartupInfo", "" },               //  启动错误信息
        };

        /// <summary>
        /// 程序入口点
        /// </summary>
        /// <param name="args">参数列表</param>
        public static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
                ArgResolve(ref args, i, ref i);
            AppendTodo();
            foreach (var action in Todo)
                action.Invoke();
        }

        /// <summary>
        /// 添加待办事项
        /// </summary>
        private static void AppendTodo()
        {
            if (Flags["PrintCopyRight"]) Todo.Add(new Action(() => Copyright()));
            if (Flags["EchoOn"]) Todo.Add(new Action(() => Console.WriteLine(
                BaseHelper.BuildString(int.Parse(Values["SeparateStrLength"]), '=')
            )));
            if (Flags["ErrStartupArgs"]) Todo.Add(new Action(() =>
                BaseHelper.WriteLine(Values["ErrStartupInfo"], ConsoleColor.Red)
            ));
        }

        /// <summary>
        /// 解释文件执行
        /// </summary>
        /// <param name="entryFileName">入口文件路径</param>
        private static void Interpret(string entryFileName)
        {

        }

        /// <summary>
        /// 参数处理函数
        /// </summary>
        /// <param name="args">参数列表引用</param>
        /// <param name="index">待处理参数角标</param>
        /// <param name="i">待处理参数角标引用</param>
        private static void ArgResolve(ref string[] args, int index, ref int i)
        {
            try
            {
                string fp = Path.GetFullPath(args[index]);
                if (File.Exists(fp))
                {
                    Todo.Add(new Action(() => Interpret(fp)));
                    ++i; return;
                }
                switch (args[index])
                {
                    case "--no-copyright":
                        Flags["PrintCopyRight"] = false;
                        break;
                    case "--echo-off":
                        Flags["EchoOn"] = false;
                        break;
                    case "--set-flag":
                        Flags[args[index + 1]] = bool.Parse(args[index + 2]);
                        i += 2;
                        break;
                    case "--set-value":
                        Values[args[index + 1]] = args[index + 2];
                        i += 2;
                        break;
                }
            }
            catch (IndexOutOfRangeException ioe)
            {
                Flags["ErrStartupArgs"] = true;
                Values["ErrStartupInfo"] = "[ErrInfo] StartUp Arguments are wrong.\n" +
                    $"{ioe.Message}\n" +
                    $"{Environment.StackTrace}";
            }
        }

        /// <summary>
        /// 输出版权信息以及一些基础信息
        /// </summary>
        private static void Copyright() => Console.WriteLine(
            $"WDScript Interpreter Native\n" +
            $"Copyright © Catrol 2022-present\n" +
            $"All Rights Reserved.\n" +
            $"{Environment.OSVersion}\n" +
            $"{AppDomain.CurrentDomain.BaseDirectory}"
        );
    }
}