using ImproHipoApiUX.MemoryCaching.Service;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace ImproHipoApiUX.MemoryCaching.Implement
{
    public class CacheServiceForProdBase : ICacheService
    {
        protected readonly IDatabase iCacheDb;

        public CacheServiceForProdBase()
        {
            var connectionString = "172.19.119.173:6379,allowAdmin=true,connectTimeout=1000,syncTimeout=1000,abortConnect=false,ssl=false";
            var redis = ConnectionMultiplexer.Connect(connectionString);
            iCacheDb = redis.GetDatabase();
        }

        public T GetData<T>(string key)
        {

            var value = iCacheDb.StringGet(key);
            if (!string.IsNullOrEmpty(value))
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default;
        }

        public object RemoveData<T>(string key)
        {
            throw new NotImplementedException();
        }

        public bool SetData<T>(string key, T value, DateTimeOffset expiration)
        {
            var expire = expiration.DateTime.Subtract(DateTime.Now);
            string serializedData = JsonConvert.SerializeObject(value);
            var isSet = iCacheDb.StringSet(key, serializedData, expire);
            return isSet;
        }
    }
}
