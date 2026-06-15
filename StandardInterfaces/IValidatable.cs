namespace StandardInterfaces
{
    /// <summary>Supports self-validation.</summary>
    public interface IValidatable
    {
        /// <summary>Returns <c>true</c> if the instance is in a valid state.</summary>
        bool IsValid();
    }

    /// <summary>Supports validation using an external <typeparamref name="T"/> validator.</summary>
    public interface IValidatable<in T>
    {
        /// <summary>Returns <c>true</c> if the instance is valid according to <paramref name="validator"/>.</summary>
        bool IsValid(T validator);
    }
}
