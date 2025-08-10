using System;
using System.Runtime.Caching;
using Interfaces;

namespace Utils.Cache
{
    public class MemoryCacheService : ICacheService
    {

        readonly ObjectCache cache;
        public MemoryCacheService() 
        {
            cache = MemoryCache.Default;
        }

        public T Get<T>(string key)
        {
            return (T) cache.Get(key);
        }

        public void Set<T>(string key, T value, int cacheSeconds)
        {
            //CacheItemPolicy policy = new CacheItemPolicy();
            //policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(cacheMinutes);         
            //cache.Set(key, value, policy);
            cache.Set(key, value, new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(cacheSeconds) });
        }

        //public void Set<T>(string key, T value)
        //{
        //   Set(key, value, 900);
        //}
        
        public void Remove(string key)
        {
                cache.Remove(key);
        }

    }
}