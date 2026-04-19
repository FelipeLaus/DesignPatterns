namespace Iterator
{
    public interface IColecaoIteravel<T>
    {
        IIterator<T> CriarIterator();
    }
}
