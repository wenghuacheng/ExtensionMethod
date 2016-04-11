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
        ///     Searches for the specified object and returns the index of the last occurrence within the entire one-
        ///     dimensional .
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <returns>
        ///     The index of the last occurrence of  within the entire , if found; otherwise, the lower bound of the array
        ///     minus 1.
        /// </returns>
        public static Int32 LastIndexOf(this Array array, Object value)
        {
            return Array.LastIndexOf(array, value);
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the last occurrence within the range of elements
        ///     in the one-dimensional  that extends from the first element to the specified index.
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <returns>
        ///     The index of the last occurrence of  within the range of elements in  that extends from the first element to ,
        ///     if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static Int32 LastIndexOf(this Array array, Object value, Int32 startIndex)
        {
            return Array.LastIndexOf(array, value, startIndex);
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the last occurrence within the range of elements
        ///     in the one-dimensional  that contains the specified number of elements and ends at the specified index.
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the backward search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>
        ///     The index of the last occurrence of  within the range of elements in  that contains the number of elements
        ///     specified in  and ends at , if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static Int32 LastIndexOf(this Array array, Object value, Int32 startIndex, Int32 count)
        {
            return Array.LastIndexOf(array, value, startIndex, count);
        }
        #endregion

        #region Reverse
        /// <summary>
        ///     Reverses the sequence of the elements in the entire one-dimensional .
        /// </summary>
        /// <param name="array">The one-dimensional  to reverse.</param>
        public static void Reverse(this Array array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        ///     Reverses the sequence of the elements in a range of elements in the one-dimensional .
        /// </summary>
        /// <param name="array">The one-dimensional  to reverse.</param>
        /// <param name="index">The starting index of the section to reverse.</param>
        /// <param name="length">The number of elements in the section to reverse.</param>
        public static void Reverse(this Array array, Int32 index, Int32 length)
        {
            Array.Reverse(array, index, length);
        }
        #endregion

        #region Sort
        /// <summary>
        ///     Sorts the elements in an entire one-dimensional  using the  implementation of each element of the .
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        public static void Sort(this Array array)
        {
            Array.Sort(array);
        }

        /// <summary>
        ///     Sorts a pair of one-dimensional  objects (one contains the keys and the other contains the corresponding
        ///     items) based on the keys in the first  using the  implementation of each key.
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="items">
        ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
        ///     null to sort only the .
        /// </param>
        /// ###
        /// <param name="keys">The one-dimensional  that contains the keys to sort.</param>
        public static void Sort(this Array array, Array items)
        {
            Array.Sort(array, items);
        }

        /// <summary>
        ///     Sorts the elements in a range of elements in a one-dimensional  using the  implementation of each element of
        ///     the .
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        public static void Sort(this Array array, Int32 index, Int32 length)
        {
            Array.Sort(array, index, length);
        }

        /// <summary>
        ///     Sorts a range of elements in a pair of one-dimensional  objects (one contains the keys and the other contains
        ///     the corresponding items) based on the keys in the first  using the  implementation of each key.
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="items">
        ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
        ///     null to sort only the .
        /// </param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// ###
        /// <param name="keys">The one-dimensional  that contains the keys to sort.</param>
        public static void Sort(this Array array, Array items, Int32 index, Int32 length)
        {
            Array.Sort(array, items, index, length);
        }

        /// <summary>
        ///     Sorts the elements in a one-dimensional  using the specified .
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
        ///     each element.
        /// </param>
        public static void Sort(this Array array, IComparer comparer)
        {
            Array.Sort(array, comparer);
        }

        /// <summary>
        ///     Sorts a pair of one-dimensional  objects (one contains the keys and the other contains the corresponding
        ///     items) based on the keys in the first  using the specified .
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="items">
        ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
        ///     null to sort only the .
        /// </param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
        ///     each element.
        /// </param>
        /// ###
        /// <param name="keys">The one-dimensional  that contains the keys to sort.</param>
        public static void Sort(this Array array, Array items, IComparer comparer)
        {
            Array.Sort(array, items, comparer);
        }

        /// <summary>
        ///     Sorts the elements in a range of elements in a one-dimensional  using the specified .
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
        ///     each element.
        /// </param>
        public static void Sort(this Array array, Int32 index, Int32 length, IComparer comparer)
        {
            Array.Sort(array, index, length, comparer);
        }

        /// <summary>
        ///     Sorts a range of elements in a pair of one-dimensional  objects (one contains the keys and the other contains
        ///     the corresponding items) based on the keys in the first  using the specified .
        /// </summary>
        /// <param name="array">The one-dimensional  to sort.</param>
        /// <param name="items">
        ///     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
        ///     null to sort only the .
        /// </param>
        /// <param name="index">The starting index of the range to sort.</param>
        /// <param name="length">The number of elements in the range to sort.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or-null to use the  implementation of
        ///     each element.
        /// </param>
        /// ###
        /// <param name="keys">The one-dimensional  that contains the keys to sort.</param>
        public static void Sort(this Array array, Array items, Int32 index, Int32 length, IComparer comparer)
        {
            Array.Sort(array, items, index, length, comparer);
        }
        #endregion

        /// <summary>
        ///     Copies a specified number of bytes from a source array starting at a particular offset to a destination array
        ///     starting at a particular offset.
        /// </summary>
        /// <param name="src">The source buffer.</param>
        /// <param name="srcOffset">The zero-based byte offset into .</param>
        /// <param name="dst">The destination buffer.</param>
        /// <param name="dstOffset">The zero-based byte offset into .</param>
        /// <param name="count">The number of bytes to copy.</param>
        public static void BlockCopy(this Array src, Int32 srcOffset, Array dst, Int32 dstOffset, Int32 count)
        {
            Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
        }

        /// <summary>
        ///     Returns the number of bytes in the specified array.
        /// </summary>
        /// <param name="array">An array.</param>
        /// <returns>The number of bytes in the array.</returns>
        public static Int32 ByteLength(this Array array)
        {
            return Buffer.ByteLength(array);
        }

        /// <summary>
        ///     Retrieves the byte at a specified location in a specified array.
        /// </summary>
        /// <param name="array">An array.</param>
        /// <param name="index">A location in the array.</param>
        /// <returns>Returns the  byte in the array.</returns>
        public static Byte GetByte(this Array array, Int32 index)
        {
            return Buffer.GetByte(array, index);
        }

        /// <summary>
        ///     Assigns a specified value to a byte at a particular location in a specified array.
        /// </summary>
        /// <param name="array">An array.</param>
        /// <param name="index">A location in the array.</param>
        /// <param name="value">A value to assign.</param>
        public static void SetByte(this Array array, Int32 index, Byte value)
        {
            Buffer.SetByte(array, index, value);
        }

        /// <summary>
        ///     An Array extension method that check if the array is lower then the specified index.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="index">Zero-based index of the.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool WithinIndex(this Array @this, int index)
        {
            return index >= 0 && index < @this.Length;
        }

        /// <summary>
        ///     An Array extension method that check if the array is lower then the specified index.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="index">Zero-based index of the.</param>
        /// <param name="dimension">(Optional) the dimension.</param>
        /// <returns>true if it succeeds, false if it fails.</returns>
        public static bool WithinIndex(this Array @this, int index, int dimension = 0)
        {
            return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
        }
    }
}
