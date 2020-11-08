using System.Text.Json;

namespace patterns.library.Prototype
{
    public static class Prototype
    {
        public static T DeepCopy<T>(this T self) where T : class
        {
            var copy = JsonSerializer.SerializeToUtf8Bytes(self, typeof(T));
            var utf8Reader = new Utf8JsonReader(copy);
            return JsonSerializer.Deserialize<T>(ref utf8Reader);
        }
    }
}