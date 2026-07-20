using System;
using PayloadBuilder.Models;

namespace PayloadBuilder.Builders
{
    public static class PayloadValidator
    {
        public static void Validate(Payload payload)
        {
            if (string.IsNullOrWhiteSpace(payload.Name))
                throw new Exception("Payload must have a name.");

            foreach (var kv in payload.Fields)
            {
                if (kv.Key == null || kv.Key.Trim() == "")
                    throw new Exception("Payload contains a field with an empty key.");

                if (kv.Value == null)
                    throw new Exception($"Field '{kv.Key}' has a null value.");
            }
        }
    }
}
