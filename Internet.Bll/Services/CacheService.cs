using Internet.Bll.Interfaces;
using StackExchange.Redis;
using System.Text.Json;

namespace Internet.Bll.Services
{
    public class CacheService : ICacheService
    {
        private IDatabase _cacheDb;
        public CacheService()
        {
            var redis = ConnectionMultiplexer.Connect("");
            _cacheDb = redis.GetDatabase();
        }
        public T GetData<T>(string key)
        {
            var value = _cacheDb.StringGet(key);
            if (!string.IsNullOrEmpty(value))
            {
                return JsonSerializer.Deserialize<T>(value);
            }
            return default;
        }

        public object RemoveData(string key)
        {
            var exist = _cacheDb.KeyExists(key);

            if (exist)
            {
                return _cacheDb.KeyDelete(key);
            }
            return false;
        }

        public bool SetData<T>(string key, T data, DateTimeOffset expirationTime)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve
            };

            string jsonString = JsonSerializer.Serialize(data, options);
            var expirityTime = expirationTime.DateTime.Subtract(DateTime.Now);
            return _cacheDb.StringSet(key, jsonString, expirityTime);
        }
    }
}
