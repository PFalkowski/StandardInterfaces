namespace StandardInterfaces
{
    public interface IFactory<out T>
    {
        T GetInstance();
    }
}
