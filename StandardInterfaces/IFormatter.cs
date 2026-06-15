namespace StandardInterfaces
{
    /// <summary>Formats a value of type <typeparamref name="T"/> as a string.</summary>
    public interface IFormatter<in T>
    {
        /// <summary>Returns a formatted string representation of <paramref name="input"/>.</summary>
        string Format(T input);
    }
}
