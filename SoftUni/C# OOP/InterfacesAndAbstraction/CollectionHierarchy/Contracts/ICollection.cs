namespace CollectionHierarchy.Contracts
{
    public interface ICollection<T> : IAdd_able<T>, IRemoveable<T>
    {
        public int Used();
    }
}
