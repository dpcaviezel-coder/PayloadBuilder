using System.Collections.Generic;

namespace PayloadBuilder.Models
{
    public class Payload
    {
        public string Name { get; set; } = "";
        public Dictionary<string, object> Fields { get; set; } = new();

        public override string ToString()
        {
            var list = new List<string>();
            foreach (var kv in Fields)
                list.Add($"{kv.Key}: {kv.Value}");

            return $"{Name}\n" + string.Join("\n", list);
        }
    }
}
