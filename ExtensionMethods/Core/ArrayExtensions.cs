using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    /// <summary>
    /// 静态集合扩展类
    /// </summary>
    public static class ArrayExtensions
    {
        #region BinarySearch
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="array">被搜索集合</param>
        /// <param name="value">搜索值</param>
        /// <returns>查询对象索引位置</returns>
        public static Int32 BinarySearch(this Array array, Object value)
        {
            return Array.BinarySearch(array, value);
        }

        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="array">被搜索集合</param>
        /// <param name="index">搜索开始索引</param>
        /// <param name="length">搜索长度</param>
        /// <param name="value">搜索值</param>
        /// <returns>查询对象索引位置</returns>
        public static Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value)
        {
            return Array.BinarySearch(array, index, length, value);
        }

        /// <summary>
        ///  二分查找
        /// </summary>
        /// <param name="array">被搜索集合</param>
        /// <param name="value">搜索值</param>
        /// <param name="comparer">比较接口</param>
        /// <returns>查询对象索引位置</returns>
        public static Int32 BinarySearch(this Array array, Object value, IComparer comparer)
        {
            return Array.BinarySearch(array, value, comparer);
        }

        /// <summary>
        ///  二分查找
        /// </summary>
        /// <param name="array">被搜索集合</param>
        /// <param name="index">搜索开始索引</param>
        /// <param name="length">搜索长度</param>
        /// <param name="value">搜索值</param>
        /// <param name="comparer">比较接口</param>
        /// <returns>查询对象索引位置</returns>
        public static Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value, IComparer comparer)
        {
            return Array.BinarySearch(array, index, length, value, comparer);
        }
        #endregion

        #region Copy
        /// <summary>
        /// 将数组的部分复制到新的某一部分集合(对复制要求严格，只能是同类型或者源数组类型是目标类型的派生元素类型)
        /// </summary>
        /// <param name="sourceArray">源数据</param>
        /// <param name="sourceIndex">源起始索引</param>
        /// <param name="destinationArray">目标集合</param>
        /// <param name="destinationIndex">目标集合赋值开始索引</param>
        /// <param name="length">复制长度</param>
        public static void ConstrainedCopy(this Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length)
        {
            Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }
       
        /// <summary>
        /// 拷贝数组内容（可装箱，拆箱复制）
        /// </summary>
        /// <param name="sourceArray">源数据</param>
        /// <param name="destinationArray">目标数据</param>
        /// <param name="length">复制长度</param>
        public static void Copy(this Array sourceArray, Array destinationArray, Int32 length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        /// <summary>
        /// 拷贝数组内容（可装箱，拆箱复制）
        /// </summary>
        /// <param name="sourceArray">源数据</param>
        /// <param name="sourceIndex">源起始索引</param>
        /// <param name="destinationArray">目标数据</param>
        /// <param name="destinationIndex">目标集合赋值开始索引</param>
        /// <param name="length">复制长度</param>
        public static void Copy(this Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        /// <summary>
        /// 拷贝数组内容（可装箱，拆箱复制）
        /// </summary>
        /// <param name="sourceArray">源数据</param>
        /// <param name="destinationArray">目标数据</param>
        /// <param name="length">复制长度</param>
        public static void Copy(this Array sourceArray, Array destinationArray, Int64 length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        /// <summary>
        ///  拷贝数组内容（可装箱，拆箱复制）
        /// </summary>
        /// <param name="sourceArray">源数据</param>
        /// <param name="sourceIndex">源起始索引</param>
        /// <param name="destinationArray">目标数据</param>
        /// <param name="destinationIndex">目标集合赋值开始索引</param>
        /// <param name="length">复制长度</param>
        public static void Copy(this Array sourceArray, Int64 sourceIndex, Array destinationArray, Int64 destinationIndex, Int64 length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }
        #endregion

        #region Clear
        /// <summary>
        /// 将指定位置的集合清空(至0/false/null)
        /// </summary>
        /// <param name="array">集合</param>
        /// <param name="index">开始索引</param>
        /// <param name="length">长度</param>
        public static void Clear(this Array array, Int32 index, Int32 length)
        {
            Array.Clear(array, index, length);
        }

        /// <summary>
        /// 集合清空
        /// </summary>
        /// <param name="this"></param>
        public static void ClearAll(this Array @this)
        {
            Array.Clear(@this, 0, @this.Length);
        }
        #endregion

        #region IndexOf
        /// <summary>获取对象所在集合的索引</summary>
        /// <param name="array">搜索集合</param>
        /// <param name="value">搜索对象</param>
        /// <returns>对象位置</returns>
        public static Int32 IndexOf(this Array array, Object value)
        {
            return Array.IndexOf(array, value);
        }

        /// <summary>获取对象所在集合的索引</summary>
        /// <param name="array">搜索集合</param>
        /// <param name="value">搜索对象</param>
        /// <param name="startIndex">搜索起始位置</param>
        /// <returns>对象位置</returns>
        public static Int32 IndexOf(this Array array, Object value, Int32 startIndex)
        {
            return Array.IndexOf(array, value, startIndex);
        }

        /// <summary>获取对象所在集合的索引</summary>
        /// <param name="array">搜索集合</param>
        /// <param name="value">搜索对象</param>
        /// <param name="startIndex">搜索起始位置</param>
        /// <param name="count">搜索长度</param>
        /// <returns>对象位置</returns>
        public static Int32 IndexOf(this Array array, Object value, Int32 startIndex, Int32 count)
        {
            return Array.IndexOf(array, value, startIndex, count);
        }

        /// <summary>
        /// 对象匹配集合的最后一个索引位置
        /// </summary>
        /// <param name="array">搜索集合</param>
        /// <param name="value">搜索对象</param>
        /// <returns>对象位置</returns>
        public static Int32 LastIndexOf(this Array array, Object value)
        {
            return Array.LastIndexOf(array, value);
        }

        /// <summary>
        /// 对象匹配集合的最后一个索引位置
        /// </summary>
        /// <param name="array">搜索集合</param>
        /// <param name="value">搜索对象</param>
        /// <param name="startIndex">搜索起始位置</param>
        /// <returns>对象位置</returns>
        public static Int32 LastIndexOf(this Array array, Object value, Int32 startIndex)
        {
            return Array.LastIndexOf(array, value, startIndex);
        }

        /// <summary>
        /// 对象匹配集合的最后一个索引位置
        /// </summary>
        /// <param name="array">搜索集合</param>
        /// <param name="value">搜索对象</param>
        /// <param name="startIndex">搜索起始位置</param>
        /// <param name="count">搜索长度</param>
        /// <returns>对象位置</returns>
        public static Int32 LastIndexOf(this Array array, Object value, Int32 startIndex, Int32 count)
        {
            return Array.LastIndexOf(array, value, startIndex, count);
        }
        #endregion

        #region Reverse
        /// <summary>
        /// 翻转数组中的顺序
        /// </summary>
        /// <param name="array">数组</param>
        public static void Reverse(this Array array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// 翻转数组中的顺序
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="index">起始位置</param>
        /// <param name="length">长度</param>
        public static void Reverse(this Array array, Int32 index, Int32 length)
        {
            Array.Reverse(array, index, length);
        }
        #endregion

        #region Sort
        /// <summary>
        /// 通过对象的IComparable接口进行对象排序
        /// </summary>
        /// <param name="array">排序数组</param>
        public static void Sort(this Array array)
        {
            Array.Sort(array);
        }

        /// <summary>
        /// 通过对象的IComparable接口进行对象排序
        /// </summary>
        /// <param name="array">排序数组</param>
        /// <param name="index">起始索引</param>
        /// <param name="length">长度</param>
        public static void Sort(this Array array, Int32 index, Int32 length)
        {
            Array.Sort(array, index, length);
        }

        /// <summary>
        /// 通过IComparable接口进行对象排序
        /// </summary>
        /// <param name="array">排序数组</param>
        /// <param name="comparer">排序接口</param>
        public static void Sort(this Array array, IComparer comparer)
        {
            Array.Sort(array, comparer);
        }

        /// <summary>
        /// 通过IComparable接口进行对象排序
        /// </summary>
        /// <param name="array">排序数组</param>
        /// <param name="index">起始索引</param>
        /// <param name="length">长度</param>
        /// <param name="comparer">排序接口</param>
        public static void Sort(this Array array, Int32 index, Int32 length, IComparer comparer)
        {
            Array.Sort(array, index, length, comparer);
        }       
        #endregion

        /// <summary>
        ///  将指定数目的字节从起始于特定偏移量的源数组复制到起始于特定偏移量的目标数组
        /// </summary>
        /// <param name="src">源数组</param>
        /// <param name="srcOffset">源数组偏移量</param>
        /// <param name="dst">目标数组</param>
        /// <param name="dstOffset">目标数组的字节偏移量</param>
        /// <param name="count">要复制的字节数</param>
        public static void BlockCopy(this Array src, Int32 srcOffset, Array dst, Int32 dstOffset, Int32 count)
        {
            Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
        }

        /// <summary>
        /// 获取数组中字节数
        /// </summary>
        /// <param name="array">数组</param>
        /// <returns>字节数</returns>
        public static Int32 ByteLength(this Array array)
        {
            return Buffer.ByteLength(array);
        }

        /// <summary>
        /// 获取指定位置的字节数
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="index">指定位置</param>
        /// <returns>字节</returns>
        public static Byte GetByte(this Array array, Int32 index)
        {
            return Buffer.GetByte(array, index);
        }

        /// <summary>
        /// 将指定的值分配给指定数组中特定位置处的字节。
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="index">指定位置</param>
        /// <param name="value">指定值</param>
        public static void SetByte(this Array array, Int32 index, Byte value)
        {
            Buffer.SetByte(array, index, value);
        }

        /// <summary>
        /// 索引是否超过意味数组界限
        /// </summary>
        /// <param name="this">数组</param>
        /// <param name="index">判断的索引</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool WithinIndex(this Array @this, int index)
        {
            return index >= 0 && index < @this.Length;
        }
    }
}
