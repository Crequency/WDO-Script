using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDScript.WDScript.Models.Standard
{
    public class StandardHelper
    {
        /// <summary>
        /// 返回 a 与 b 中较大的一个的引用
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="a">泛型 a</param>
        /// <param name="b">泛型 b</param>
        /// <returns>较大者</returns>
        public static ref T Max<T>(ref T a, ref T b) where T : notnull, IComparable<T>
        {
            if (a.CompareTo(b) > 0) return ref a;
            else return ref b;
        }

        /// <summary>
        /// 返回 a 与 b 中较小的一个的引用
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="a">泛型 a</param>
        /// <param name="b">泛型 b</param>
        /// <returns>较小者</returns>
        public static ref T Min<T>(ref T a, ref T b) where T : notnull, IComparable<T>
        {
            if (a.CompareTo(b) < 0) return ref a;
            else return ref b;
        }

        /// <summary>
        /// 返回 a 与 b 中较大的一个的值
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="a">泛型 a</param>
        /// <param name="b">泛型 b</param>
        /// <returns>较大者</returns>
        public static T MaxValue<T>(T a, T b) where T : notnull, IComparable<T> => a.CompareTo(b) > 0 ? a : b;

        /// <summary>
        /// 返回 a 与 b 中较小的一个的值
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="a">泛型 a</param>
        /// <param name="b">泛型 b</param>
        /// <returns>较小者</returns>
        public static T MinValue<T>(T a, T b) where T : notnull, IComparable<T> => a.CompareTo(b) < 0 ? a : b;

        /// <summary>
        /// 自头部开始复制
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="a">数组 a</param>
        /// <param name="b">数组 b</param>
        public static void HeadCpy<T>(ref T[] a, ref T[] b)
        {
            for (int i = 0; i < a.Length; ++i) b[i] = a[i];
        }

        /// <summary>
        /// 数组范围初始化
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="a">数组</param>
        /// <param name="b">待填入的内容</param>
        /// <param name="start">起始下标</param>
        /// <param name="length">要覆盖的长度</param>
        public static void Arrset<T>(ref T[] a, T b, int start, int length)
        {
            for (int i = start; i < start + length; ++i) a[i] = b;
        }
    }
}
