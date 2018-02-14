using System.Collections.Generic;
using Xamarin.UITest;

namespace Mobile.Automation.ScreenObjects
{
    public static class Current
    {
        private static readonly IDictionary<string, object> Cache = new Dictionary<string, object>();

        public static Platform Platform
        {
            get { return Get<Platform>("PLATFORM"); }
            set { Put<Platform>("PLATFORM", value); }
        }

        private static T Get<T>(string key)
        {
            if (!Cache.ContainsKey(key))
            {
                throw new KeyNotFoundException($"Key not found in cache: '{key}'");
            }
            return (T)Cache[key];
        }

        private static void Put<T>(string key, object value)
        {
            if (!Cache.ContainsKey(key))
            {
                Cache.Add(key, value);
            }
            else
            {
                Cache.Remove(key);
                Cache.Add(key, value);
            }
        }
    }
}
