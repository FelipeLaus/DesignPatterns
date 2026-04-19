namespace Iterator
{
    public interface IIterator<T>
    {
        bool TemProximo();
        T Proximo();
        void Reiniciar();
    }
}
