namespace Functionality.Serialization;

internal interface ISerializer
{
    T? Deserialize<T>(string input);
    string Serialize<T>(T obj);
}