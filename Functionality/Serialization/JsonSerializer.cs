namespace Functionality.Serialization.Abstractions;

internal class JsonSerializer : ISerializer
{
    public T? Deserialize<T>(string input) => System.Text.Json.JsonSerializer.Deserialize<T>(input);
    
    public string Serialize<T>(T obj) => System.Text.Json.JsonSerializer.Serialize(obj);
}

