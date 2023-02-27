using Functionality.Serialization.Abstractions;

namespace Functionality.Serialization;

internal class FileSerializer : IFileSerializer
{
    private readonly ISerializer _serializer;

    public FileSerializer(ISerializer serializer)
    {
        _serializer = serializer;
    }

    public T? Deserialize<T>(string fileName) => _serializer.Deserialize<T>(File.ReadAllText(fileName));

    public void Serialize<T>(T obj, string fileName) => File.WriteAllText(fileName, _serializer.Serialize(obj));
}