using DRPS.Reflection;
using Functionality.Serialization.Abstractions;

namespace Functionality;

internal static class InstanceSerializationService<T> where T : class
{
    public static void Serialize(IFileSerializer serializer, string fileName)
    {
        var vehicles = InstanceService.GetInstances<T>();

        Serialize(vehicles, serializer, fileName);
    }

    private static void Serialize(IEnumerable<T> vehicles, IFileSerializer serializer, string fileName)
    {
        serializer.Serialize(vehicles, fileName);
    }
}