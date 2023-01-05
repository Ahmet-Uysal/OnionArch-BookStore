namespace BookStore.Application.Abstractions
{
    public interface IObjectOperations
    {
        void CopyProperties<T, E>(T source, E target) where T : class where E : class;
    }
}