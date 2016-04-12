using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class TArrayExtensions
    {
        /// <summary>
        /// 转为只读集合
        /// </summary>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array)
        {
            return Array.AsReadOnly(array);
        }

        /// <summary>
        /// 是否包含某元素
        /// </summary>
        public static Boolean Exists<T>(this T[] array, Predicate<T> match)
        {
            return Array.Exists(array, match);
        }

        /// <summary>
        /// 查找某元素
        /// </summary>
        public static T Find<T>(this T[] array, Predicate<T> match)
        {
            return Array.Find(array, match);
        }

        /// <summary>
        /// 查找所有符合条件的元素
        /// </summary>
        public static T[] FindAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindAll(array, match);
        }

        /// <summary>
        /// 查找符合条件的元素索引
        /// </summary>
        public static Int32 FindIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindIndex(array, match);
        }

        /// <summary>
        /// 查找符合条件的元素索引
        /// </summary>
        public static Int32 FindIndex<T>(this T[] array, Int32 startIndex, Predicate<T> match)
        {
            return Array.FindIndex(array, startIndex, match);
        }

        /// <summary>
        /// 查找符合条件的元素索引
        /// </summary>
        public static Int32 FindIndex<T>(this T[] array, Int32 startIndex, Int32 count, Predicate<T> match)
        {
            return Array.FindIndex(array, startIndex, count, match);
        }

        /// <summary>
        /// 查找符合条件的最后一个元素
        /// </summary>
        public static T FindLast<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLast(array, match);
        }

        /// <summary>
        /// 查找符合条件的最后一个元素索引
        /// </summary>
        public static Int32 FindLastIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLastIndex(array, match);
        }

        /// <summary>
        ///  查找符合条件的最后一个元素索引
        /// </summary>
        public static Int32 FindLastIndex<T>(this T[] array, Int32 startIndex, Predicate<T> match)
        {
            return Array.FindLastIndex(array, startIndex, match);
        }

        /// <summary>
        /// 查找符合条件的最后一个元素索引
        /// </summary>
        public static Int32 FindLastIndex<T>(this T[] array, Int32 startIndex, Int32 count, Predicate<T> match)
        {
            return Array.FindLastIndex(array, startIndex, count, match);
        }

        /// <summary>
        /// 遍历操作
        /// </summary>
        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            Array.ForEach(array, action);
        }

        /// <summary>
        /// 确定数组中的每个元素是否都与指定谓词定义的条件匹配
        /// </summary>
        public static Boolean TrueForAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.TrueForAll(array, match);
        }

        /// <summary>
        /// 清空数组
        /// </summary>
        public static void ClearAll<T>(this T[] @this)
        {
            Array.Clear(@this, 0, @this.Length);
        }

        /// <summary>
        /// 删除数组中某个元素
        /// </summary>
        public static void ClearAt<T>(this T[] @this, int at)
        {
            Array.Clear(@this, at, 1);
        }

        /// <summary>
        ///  对象转为DataTable
        /// </summary>
        /// <returns>@this as a DataTable.</returns>
        public static DataTable ToDataTable<T>(this T[] @this)
        {
            Type type = typeof(T);

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var dt = new DataTable();

            foreach (PropertyInfo property in properties)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }

            foreach (FieldInfo field in fields)
            {
                dt.Columns.Add(field.Name, field.FieldType);
            }

            foreach (T item in @this)
            {
                DataRow dr = dt.NewRow();

                foreach (PropertyInfo property in properties)
                {
                    dr[property.Name] = property.GetValue(item, null);
                }

                foreach (FieldInfo field in fields)
                {
                    dr[field.Name] = field.GetValue(item);
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
