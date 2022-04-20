using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDOScript
{
    internal class BaseHelper
    {
        /// <summary>
        /// 指定长度字符构造字符串
        /// </summary>
        /// <param name="length">长度</param>
        /// <param name="sign">字符</param>
        /// <returns>构造好的字符串</returns>
        internal static string BuildString(int length, char sign)
        {
            var sb = new StringBuilder();
            sb.Append(sign, length);
            return sb.ToString();
        }

        /// <summary>
        /// 控制台彩色打印
        /// </summary>
        /// <param name="content">打印内容</param>
        /// <param name="cc">颜色</param>
        internal static void Write(string content, ConsoleColor cc)
        {
            ConsoleColor ccn = Console.ForegroundColor;
            Console.ForegroundColor = cc;
            Console.Write(content);
            Console.ForegroundColor = ccn;
        }

        /// <summary>
        /// 控制台彩色打印追加换行
        /// </summary>
        /// <param name="content">打印内容</param>
        /// <param name="cc">颜色</param>
        internal static void WriteLine(string content, ConsoleColor cc)
        {
            ConsoleColor ccn = Console.ForegroundColor;
            Console.ForegroundColor = cc;
            Console.WriteLine(content);
            Console.ForegroundColor = ccn;
        }
    }
}
