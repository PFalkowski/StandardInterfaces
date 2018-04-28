namespace StandardInterfaces
{
    public interface IConverter<in TFrom, out TTo>
    {
        TTo Convert(TFrom input);
    }
}
