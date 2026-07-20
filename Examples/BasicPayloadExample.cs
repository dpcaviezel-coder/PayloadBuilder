using System;
using PayloadBuilder.Builders;
using PayloadBuilder.Serialization;

namespace PayloadBuilder.Examples
{
    public static class BasicPayloadExample
    {
        public static void Run()
        {
            Console.WriteLine("BasicPayloadExample:");

            var payload = new PayloadBuilder()
                .SetName("UserProfile")
                .AddField("username", "ExampleUser")
                .AddField("level", 42)
                .AddField("isPremium", true)
                .Build();

            PayloadValidator.Validate(payload);

            var json = PayloadSerializer.ToJson(payload);

            Console.WriteLine(json);
        }
    }
}
