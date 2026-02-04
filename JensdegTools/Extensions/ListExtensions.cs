
namespace JensdegTools.Extensions;

/// <summary>
/// Provides extension methods for working with generic lists.
/// </summary>
public static class ListExtensions
{
    /// <summary>
    /// Determines whether the list contains at least one element whose runtime type matches the specified type.
    /// </summary>
    /// <remarks>This method compares the runtime type of each element in the list to the specified type using
    /// reference equality. It does not consider derived types or interface implementations; only exact type matches are
    /// counted.</remarks>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    /// <param name="list">The list to search for an element of the specified type. Cannot be null.</param>
    /// <param name="type">The type to compare against the runtime type of elements in the list. Cannot be null.</param>
    /// <returns>true if the list contains at least one element whose runtime type is equal to the specified type; otherwise,
    /// false.</returns>
    public static bool ContainsType<T>(this List<T> list, Type type)
        => list.Where(s => s?.GetType() == type).Any();
}
