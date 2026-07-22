
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

            var payload = new PayloadCreator()
            .WithName("UserProfile")
            .WithField("username", "ExampleUser")
            .WithField("level", 42)
            .WithField("isPremium", true)
            .Build();




            PayloadValidator.Validate(payload);

            var json = PayloadSerializer.ToJson(payload);

            Console.WriteLine(json);
        }
    }
}

