namespace DeveloperTest.Reflection;

public static class InstanceService
{
    public static IEnumerable<T> GetInstances<T>() where T : class =>
        typeof(T).GetSubtypes()
            .Where(type => !type.IsAbstract && type.IsClass)
            .Where(TypeExtensions.HasParameterlessConstructor)
            .Select(type => Activator.CreateInstance(type) as T)
            .OfType<T>();
}