namespace StandardInterfaces
{
    /// <summary>Supports value-based equality comparison with another instance of <typeparamref name="T"/>.</summary>
    public interface IValueEquatable<in T>
    {
        /// <summary>Returns <c>true</c> if this instance is value-equal to <paramref name="other"/>.</summary>
        bool ValueEquals(T other);
    }
}
