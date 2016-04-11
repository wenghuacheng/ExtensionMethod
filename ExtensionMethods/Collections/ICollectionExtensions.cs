using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Collections
{
    public static class ICollectionExtensions
    {
        /// <summary>
        /// 当值满足添加是添加到集合
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="predicate">添加值验证</param>
        /// <param name="value">添加值</param>
        /// <returns>成功true,失败false</returns>
        public static bool AddIf<T>(this ICollection<T> @this, Func<T, bool> predicate, T value)
        {
            if (predicate(value))
            {
                @this.Add(value);
                return true;
            }

            return false;
        }

        /// <summary>
        /// 当值不在集合中添加
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="value">添加值</param>
        /// <returns>成功true,失败false</returns>
        public static bool AddIfNotContains<T>(this ICollection<T> @this, T value)
        {
            if (!@this.Contains(value))
            {
                @this.Add(value);
                return true;
            }

            return false;
        }

        /// <summary>
        /// 将数组添加到集合中
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="values">添加数组</param>
        public static void AddRange<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                @this.Add(value);
            }
        }

        /// <summary>
        /// 将数组中满足要求的值添加到集合中
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="predicate">添加值验证</param>
        /// <param name="values">添加数组</param>
        public static void AddRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (T value in values)
            {
                if (predicate(value))
                {
                    @this.Add(value);
                }
            }
        }

        /// <summary>
        /// 当数组中值不在集合中添加
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="values">添加数组</param>
        public static void AddRangeIfNotContains<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                if (!@this.Contains(value))
                {
                    @this.Add(value);
                }
            }
        }

        /// <summary>
        /// 值是否都在集合中
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="values">验证数组</param>
        /// <returns>都存在true,有不存在的值false</returns>
        public static bool ContainsAll<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                if (!@this.Contains(value))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 值是否有在集合中
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="values">验证数组</param>
        /// <returns>存在true,都不存在false</returns>
        public static bool ContainsAny<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                if (@this.Contains(value))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 集合是否为空
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <returns>空true,非空false</returns>
        public static bool IsEmpty<T>(this ICollection<T> @this)
        {
            return @this.Count == 0;
        }

        /// <summary>
        /// 集合是否非空
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <returns>非空true,空false</returns>
        public static bool IsNotEmpty<T>(this ICollection<T> @this)
        {
            return @this.Count != 0;
        }

        /// <summary>
        /// 集合是否为非null非空
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <returns>非空/非null true,空false</returns>
        public static bool IsNotNullOrEmpty<T>(this ICollection<T> @this)
        {
            return @this != null && @this.Count != 0;
        }

        /// <summary>
        /// 集合是否是null或空
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <returns>空/null true,非空false</returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
        {
            return @this == null || @this.Count == 0;
        }

        /// <summary>
        /// 值满足条件则删除
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="value">被移除值</param>
        /// <param name="predicate">验证方法</param>
        public static void RemoveIf<T>(this ICollection<T> @this, T value, Func<T, bool> predicate)
        {
            if (predicate(value))
            {
                @this.Remove(value);
            }
        }

        /// <summary>
        /// 移除在集合中的值
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="value">被移除值</param>
        public static void RemoveIfContains<T>(this ICollection<T> @this, T value)
        {
            if (@this.Contains(value))
            {
                @this.Remove(value);
            }
        }

        /// <summary>
        /// 批量移除值
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="values">被移除值集合</param>
        public static void RemoveRange<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                @this.Remove(value);
            }
        }

        /// <summary>
        /// 批量移除满足条件的值
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="predicate">验证方法</param>
        /// <param name="values">被移除值集合</param>
        public static void RemoveRangeIf<T>(this ICollection<T> @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (T value in values)
            {
                if (predicate(value))
                {
                    @this.Remove(value);
                }
            }
        }

        /// <summary>
        /// 批量移除存在集合中的值
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="values">被移除值集合</param>
        public static void RemoveRangeIfContains<T>(this ICollection<T> @this, params T[] values)
        {
            foreach (T value in values)
            {
                if (@this.Contains(value))
                {
                    @this.Remove(value);
                }
            }
        }

        /// <summary>
        /// 批量移除满足条件的值与RemoveRangeIf效果相同
        /// </summary>
        /// <typeparam name="T">集合类型</typeparam>
        /// <param name="this">ICollection</param>
        /// <param name="predicate">验证方法</param>
        public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
        {
            List<T> list = @this.Where(predicate).ToList();
            foreach (T item in list)
            {
                @this.Remove(item);
            }
        }

    }
}
