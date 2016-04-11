using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;

namespace ExtensionMethods.Caching
{
    public static partial class ExtensionMemoryCache
    {
        /// <summary>MemoryCache类的扩展添加或替换缓存值</summary>
        /// <typeparam name="TValue">存储值类型</typeparam>
        /// <param name="cache">MemoryCache</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns>值</returns>
        public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, TValue value)
        {
            object item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;

            return (TValue)item;
        }

        /// <summary>MemoryCache类的扩展添加或替换缓存值</summary>
        /// <typeparam name="TValue">存储值类型</typeparam>
        /// <param name="cache">MemoryCache</param>
        /// <param name="key">键</param>
        /// <param name="valueFactory">值处理方法(处理值再进行保存)</param>
        /// <returns>值</returns>
        public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory)
        {
            var lazy = new Lazy<TValue>(() => valueFactory(key));

            Lazy<TValue> item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;

            return item.Value;
        }

        /// <summary>MemoryCache类的扩展添加或替换缓存值</summary>
        /// <typeparam name="TValue">存储值类型</typeparam>
        /// <param name="cache">MemoryCache</param>
        /// <param name="key">键</param>
        /// <param name="valueFactory">值处理方法(处理值再进行保存)</param>
        /// <param name="policy">缓存项的一组逐出和过期详细信息</param>
        /// <param name="regionName">缓存中的一个可用来添加缓存项的命名区域</param>
        /// <returns>值</returns>
        public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory, CacheItemPolicy policy, string regionName = null)
        {
            var lazy = new Lazy<TValue>(() => valueFactory(key));

            Lazy<TValue> item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, policy, regionName) ?? lazy;

            return item.Value;
        }

        /// <summary>MemoryCache类的扩展添加或替换缓存值</summary>
        /// <typeparam name="TValue">存储值类型</typeparam>
        /// <param name="cache">MemoryCache</param>
        /// <param name="key">键</param>
        /// <param name="valueFactory">值处理方法(处理值再进行保存)</param>
        /// <param name="absoluteExpiration">缓存过期时间</param>
        /// <param name="regionName">缓存中的一个可用来添加缓存项的命名区域</param>
        /// <returns>值</returns>
        public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory, DateTimeOffset absoluteExpiration, string regionName = null)
        {
            var lazy = new Lazy<TValue>(() => valueFactory(key));

            Lazy<TValue> item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, absoluteExpiration, regionName) ?? lazy;

            return item.Value;
        }
    }
}
