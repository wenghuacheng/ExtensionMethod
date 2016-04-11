﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class ArrayExtensions
    {
        #region BinarySearch
        /// <summary>
        ///     Searches an entire one-dimensional sorted  for a specific element, using the  interface implemented by each
        ///     element of the  and by the specified object.
        /// </summary>
        /// <param name="array">The sorted one-dimensional  to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>
        ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
        ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
        ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
        ///     bitwise complement of (the index of the last element plus 1).
        /// </returns>
        public static Int32 BinarySearch(this Array array, Object value)
        {
            return Array.BinarySearch(array, value);
        }

        /// <summary>
        ///     Searches a range of elements in a one-dimensional sorted  for a value, using the  interface implemented by
        ///     each element of the  and by the specified value.
        /// </summary>
        /// <param name="array">The sorted one-dimensional  to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <returns>
        ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
        ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
        ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
        ///     bitwise complement of (the index of the last element plus 1).
        /// </returns>
        public static Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value)
        {
            return Array.BinarySearch(array, index, length, value);
        }

        /// <summary>
        ///     Searches an entire one-dimensional sorted  for a value using the specified  interface.
        /// </summary>
        /// <param name="array">The sorted one-dimensional  to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or- null to use the  implementation
        ///     of each element.
        /// </param>
        /// <returns>
        ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
        ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
        ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
        ///     bitwise complement of (the index of the last element plus 1).
        /// </returns>
        public static Int32 BinarySearch(this Array array, Object value, IComparer comparer)
        {
            return Array.BinarySearch(array, value, comparer);
        }

        /// <summary>
        ///     Searches a range of elements in a one-dimensional sorted  for a value, using the specified  interface.
        /// </summary>
        /// <param name="array">The sorted one-dimensional  to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">
        ///     The  implementation to use when comparing elements.-or- null to use the  implementation
        ///     of each element.
        /// </param>
        /// <returns>
        ///     The index of the specified  in the specified , if  is found. If  is not found and  is less than one or more
        ///     elements in , a negative number which is the bitwise complement of the index of the first element that is
        ///     larger than . If  is not found and  is greater than any of the elements in , a negative number which is the
        ///     bitwise complement of (the index of the last element plus 1).
        /// </returns>
        public static Int32 BinarySearch(this Array array, Int32 index, Int32 length, Object value, IComparer comparer)
        {
            return Array.BinarySearch(array, index, length, value, comparer);
        }
        #endregion

        /// <summary>
        ///     Copies a range of elements from an  starting at the specified source index and pastes them to another
        ///     starting at the specified destination index.  Guarantees that all changes are undone if the copy does not
        ///     succeed completely.
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void ConstrainedCopy(this Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length)
        {
            Array.ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        #region Copy
        /// <summary>
        ///     Copies a range of elements from an  starting at the first element and pastes them into another  starting at
        ///     the first element. The length is specified as a 32-bit integer.
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void Copy(this Array sourceArray, Array destinationArray, Int32 length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        /// <summary>
        ///     Copies a range of elements from an  starting at the specified source index and pastes them to another
        ///     starting at the specified destination index. The length and the indexes are specified as 32-bit integers.
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
        public static void Copy(this Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }

        /// <summary>
        ///     Copies a range of elements from an  starting at the first element and pastes them into another  starting at
        ///     the first element. The length is specified as a 64-bit integer.
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="length">
        ///     A 64-bit integer that represents the number of elements to copy. The integer must be between
        ///     zero and , inclusive.
        /// </param>
        public static void Copy(this Array sourceArray, Array destinationArray, Int64 length)
        {
            Array.Copy(sourceArray, destinationArray, length);
        }

        /// <summary>
        ///     Copies a range of elements from an  starting at the specified source index and pastes them to another
        ///     starting at the specified destination index. The length and the indexes are specified as 64-bit integers.
        /// </summary>
        /// <param name="sourceArray">The  that contains the data to copy.</param>
        /// <param name="sourceIndex">A 64-bit integer that represents the index in the  at which copying begins.</param>
        /// <param name="destinationArray">The  that receives the data.</param>
        /// <param name="destinationIndex">A 64-bit integer that represents the index in the  at which storing begins.</param>
        /// <param name="length">
        ///     A 64-bit integer that represents the number of elements to copy. The integer must be between
        ///     zero and , inclusive.
        /// </param>
        public static void Copy(this Array sourceArray, Int64 sourceIndex, Array destinationArray, Int64 destinationIndex, Int64 length)
        {
            Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        }
        #endregion

        #region Clear
        /// <summary>
        ///     Sets a range of elements in the  to zero, to false, or to null, depending on the element type.
        /// </summary>
        /// <param name="array">The  whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range of elements to clear.</param>
        /// <param name="length">The number of elements to clear.</param>
        public static void Clear(this Array array, Int32 index, Int32 length)
        {
            Array.Clear(array, index, length);
        }

        /// <summary>
        ///     An Array extension method that clears the array.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        public static void ClearAll(this Array @this)
        {
            Array.Clear(@this, 0, @this.Length);
        }
        #endregion

        #region IndexOf
        /// <summary>
        ///     Searches for the specified object and returns the index of the first occurrence within the entire one-
        ///     dimensional .
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <returns>
        ///     The index of the first occurrence of  within the entire , if found; otherwise, the lower bound of the array
        ///     minus 1.
        /// </returns>
        public static Int32 IndexOf(this Array array, Object value)
        {
            return Array.IndexOf(array, value);
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the first occurrence within the range of elements
        ///     in the one-dimensional  that extends from the specified index to the last element.
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <returns>
        ///     The index of the first occurrence of  within the range of elements in  that extends from  to the last element,
        ///     if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
        public static Int32 IndexOf(this Array array, Object value, Int32 startIndex)
        {
            return Array.IndexOf(array, value, startIndex);
        }

        /// <summary>
        ///     Searches for the specified object and returns the index of the first occurrence within the range of elements
        ///     in the one-dimensional  that starts at the specified index and contains the specified number of elements.
        /// </summary>
        /// <param name="array">The one-dimensional  to search.</param>
        /// <param name="value">The object to locate in .</param>
        /// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>
        ///     The index of the first occurrence of  within the range of elements in  that starts at  and contains the
        ///     number of elements specified in , if found; otherwise, the lower bound of the array minus 1.
        /// </returns>
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