namespace Functionality.Serialization.Abstractions;

internal interface IFileSerializer
{
    T? Deserialize<T>(string fileName);
    
    void Serialize<T>(T obj, string fileName);
}