using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xtramile.Extensions
{
    public static class JsonExtension
    {
        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            IgnoreNullValues = true,
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase

        };

        public static T DeserializeT<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }

        public static async Task<T> GetAsync<T>(this HttpClient client, string url)
        {
            using var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            return json.DeserializeT<T>();
        }

        public static async Task<T> PostAsync<T>(this HttpClient client, string url, object content)
        {
            var jsonContent = JsonSerializer.Serialize(content);
            using var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            using var response = await client.PostAsync(url, httpContent);
            var json = await response.Content.ReadAsStringAsync();
            return json.DeserializeT<T>();
        }
    }
}
