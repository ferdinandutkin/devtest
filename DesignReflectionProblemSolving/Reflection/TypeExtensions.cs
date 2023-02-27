namespace DeveloperTest.Reflection;

public static class TypeExtensions
{
    public static bool HasParameterlessConstructor(this Type type) => type.GetConstructor(Type.EmptyTypes) is not null;
    
    public static IEnumerable<Type> GetSubtypes(this Type targetType) => AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(assembly => assembly.GetTypes())
        .Where(type => targetType.IsAssignableFrom(type) && type != targetType);
}