namespace StandardInterfaces
{
    public interface IBuilder<out T>
    {
        void Build();
        T Entity { get; }
    }
}
