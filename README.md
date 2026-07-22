# PayloadCreator

A lightweight C# toolkit for building, validating, and serializing structured payload objects. Useful for QA automation, API testing, game development.

## Features

- Fluent payload creator
- Field validation
- JSON serialization/deserialization
- Easy integration with other toolkits
- MATARI-ready payload templates

## Example

```csharp
var payload = new PayloadCreator()
    .SetName("UserProfile")
    .AddField("username", "Example")
    .AddField("level", 42)
    .Build();

PayloadValidator.Validate(payload);

Console.WriteLine(PayloadSerializer.ToJson(payload));
