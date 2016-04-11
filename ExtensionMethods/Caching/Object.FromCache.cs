using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Caching;
using System.Text;

namespace ExtensionMethods.Caching
{
    public static partial class ExtensionMemoryCache
    {
        /// <summary>对象的缓存扩展添加或替换缓存值</summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="this">对象</param>
        /// <param name="cache">MemoryCache</param>
        /// <param name="key">键</param>
        /// <param name="value">缓存值</param>
        /// <returns>返回值</returns>
        public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, TValue value)
        {
            object item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;

            return (TValue)item;
        }

        /// <summary>对象的缓存扩展默认缓存添加或替换缓存值</summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="this">对象</param>
        /// <param name="key">键</param>
        /// <param name="value">缓存值</param>
        /// <returns>返回值</returns>
        public static TValue FromCache<T, TValue>(this T @this, string key, TValue value)
        {
            return @this.FromCache(MemoryCache.Default, key, value);
        }

        /// <summary>对象的缓存扩展添加或替换缓存值</summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="this">对象</param>
        /// <param name="cache">缓存</param>
        /// <param name="key">键</param>
        /// <param name="valueFactory">缓存值</param>
        /// <returns>返回值</returns>
        public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, Expression<Func<T, TValue>> valueFactory)
        {
            var lazy = new Lazy<TValue>(() => valueFactory.Compile()(@this));
            Lazy<TValue> item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;
            return item.Value;
        }

        /// <summary>对象的缓存扩展添加或替换缓存值</summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="this">对象</param>
        /// <param name="key">键</param>
        /// <param name="valueFactory">值处理</param>
        /// <returns>返回值</returns>
        public static TValue FromCache<T, TValue>(this T @this, string key, Expression<Func<T, TValue>> valueFactory)
        {
            return @this.FromCache(MemoryCache.Default, key, valueFactory);
        }
    }
}
