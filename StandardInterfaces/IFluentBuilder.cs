namespace StandardInterfaces
{
    /// <summary>Builds an instance of <typeparamref name="T"/> using a fluent (method-chaining) API.</summary>
    public interface IFluentBuilder<out T>
    {
        /// <summary>Executes the build step and returns <c>this</c> for chaining.</summary>
        IFluentBuilder<T> Build();

        /// <summary>The built entity; valid after <see cref="Build"/> has been called.</summary>
        T Entity { get; }
    }
}
