namespace Functionality;

internal static class TypeService
{
    public static IEnumerable<Type> FindTypes(string namePart) =>
        AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => type.Name.Contains(namePart));
}