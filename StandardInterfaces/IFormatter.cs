namespace StandardInterfaces
{
    public interface IFormatter<in T>
    {
        string Format(T input);
    }
}
