using System.Text.Json;
using PayloadBuilder.Models;

namespace PayloadBuilder.Serialization
{
    public static class PayloadSerializer
    {
        public static string ToJson(Payload payload)
        {
            return JsonSerializer.Serialize(payload, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }

        public static Payload FromJson(string json)
        {
            return JsonSerializer.Deserialize<Payload>(json) ?? new Payload();
        }
    }
}
