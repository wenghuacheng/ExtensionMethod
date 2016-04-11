using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Collections
{
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// 数组是否包含所有的值
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <param name="values">验证值集合</param>
        /// <returns></returns>
        public static bool ContainsAll<T>(this IEnumerable<T> @this, params T[] values)
        {
            T[] list = @this.ToArray();
            foreach (T value in values)
            {
                if (!list.Contains(value))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 数组是否包含值
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <param name="values">验证值集合</param>
        /// <returns></returns>
        public static bool ContainsAny<T>(this IEnumerable<T> @this, params T[] values)
        {
            T[] list = @this.ToArray();
            foreach (T value in values)
            {
                if (list.Contains(value))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 遍历集合
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <param name="action">针对每个对象的操作</param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            T[] array = @this.ToArray();
            foreach (T t in array)
            {
                action(t);
            }
            return array;
        }

        /// <summary>遍历集合</summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <param name="action">针对每个对象的操作并传入对象的索引</param>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            T[] array = @this.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                action(array[i], i);
            }

            return array;
        }

        /// <summary>
        /// 集合是否为空
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <returns></returns>
        public static bool IsEmpty<T>(this IEnumerable<T> @this)
        {
            return !@this.Any();
        }

        /// <summary>
        /// 集合是否不为空
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <returns></returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> @this)
        {
            return @this.Any();
        }

        /// <summary>
        /// 集合是否不为空与null
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this != null && @this.Any();
        }

        /// <summary>
        /// 集合是否为空或null
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }

        /// <summary>
        /// 将集合拼接为一个字符串
        /// </summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <param name="separator">分隔符</param>
        /// <returns></returns>
        public static string StringJoin<T>(this IEnumerable<T> @this, string separator)
        {
            return string.Join(separator, @this);
        }

        #region IEnumerable<IEnumerable<T>>
        /// <summary>集合合并(其中所有的值)</summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <returns </returns>
        public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            List<IEnumerable<T>> listItem = @this.ToList();

            var list = new List<T>();

            foreach (var item in listItem)
            {
                list.AddRange(item);
            }

            return list;
        }

        /// <summary>集合合并(仅包含集合的并集)</summary>
        /// <typeparam name="T">数组类型</typeparam>
        /// <param name="this">IEnumerable</param>
        /// <returns></returns>
        public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            List<IEnumerable<T>> listItem = @this.ToList();

            var list = new List<T>();

            foreach (var item in listItem)
            {
                list = list.Union(item).ToList();
            }

            return list;
        }

        #endregion
    }
}
