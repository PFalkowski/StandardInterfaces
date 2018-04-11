namespace StandardInterfaces
{
    public interface IValueEquatable<in T>
    {
        bool ValueEquals(T other);
    }
}
