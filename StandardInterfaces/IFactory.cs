namespace StandardInterfaces
{
    /// <summary>Creates instances of <typeparamref name="T"/>.</summary>
    public interface IFactory<out T>
    {
        /// <summary>Returns a new instance of <typeparamref name="T"/>.</summary>
        T GetInstance();
    }
}
