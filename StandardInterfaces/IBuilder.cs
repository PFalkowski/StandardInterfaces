namespace StandardInterfaces
{
    /// <summary>Builds an instance of <typeparamref name="T"/> via a two-step Build/Entity pattern.</summary>
    public interface IBuilder<out T>
    {
        /// <summary>Executes the build process.</summary>
        void Build();

        /// <summary>The built entity; valid after <see cref="Build"/> has been called.</summary>
        T Entity { get; }
    }
}
