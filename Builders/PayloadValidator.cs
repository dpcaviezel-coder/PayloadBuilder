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
                if (string.IsNullOrWhiteSpace(kv.Key))
                    throw new Exception("Payload contains a field with an empty key.");

                if (kv.Value == null)
                    throw new Exception($"Field '{kv.Key}' has a null value.");
            }
        }
    }
}
