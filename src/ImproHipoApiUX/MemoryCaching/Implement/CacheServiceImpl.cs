//using Microsoft.EntityFrameworkCore.Storage;
//using Persistence.MemoryCaching.Service;
using ImproHipoApiUX.MemoryCaching.Service;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ImproHipoApiUX.MemoryCaching.Implement;

public class CacheServiceImpl : ICacheService
{
    protected readonly IDatabase iCacheDb;

    public CacheServiceImpl()
    {
        var connectionString = "172.19.119.173:6379,allowAdmin=true,connectTimeout=1000,syncTimeout=1000,abortConnect=false,ssl=false";
        var redis = ConnectionMultiplexer.Connect(connectionString);
        iCacheDb = redis.GetDatabase();
    }

    public T GetData<T>(string key)
    {

        var value = iCacheDb.StringGet(key);
        if (!string.IsNullOrEmpty(value)) { 
            return JsonSerializer.Deserialize<T>(value);
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
        var isSet = iCacheDb.StringSet(key, JsonSerializer.Serialize(value), expire);
        return isSet;
    }
}
