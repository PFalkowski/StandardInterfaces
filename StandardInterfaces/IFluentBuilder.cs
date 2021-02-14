namespace StandardInterfaces
{
    public interface IFluentBuilder<out T>
    {
        IFluentBuilder<T> Build();
        T Entity { get; }
    }
}
