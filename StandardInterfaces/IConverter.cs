namespace StandardInterfaces
{
    /// <summary>Converts a value of type <typeparamref name="TFrom"/> to <typeparamref name="TTo"/>.</summary>
    public interface IConverter<in TFrom, out TTo>
    {
        /// <summary>Converts <paramref name="input"/> and returns the result.</summary>
        TTo Convert(TFrom input);
    }
}
