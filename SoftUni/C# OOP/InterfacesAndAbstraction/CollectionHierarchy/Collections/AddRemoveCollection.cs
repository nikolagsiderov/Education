using System.Collections.Generic;

namespace CollectionHierarchy.Collections
{
    public class AddRemoveCollection<T> : Contracts.IAdd_able<T>, Contracts.IRemoveable<T>
    {
        public AddRemoveCollection(int count)
        {
            Collection = new List<T>(count);
        }

        private List<T> Collection { get; set; }

        public int Add(T item)
        {
            Collection.Insert(0, item);

            return 0;
        }

        public T Remove()
        {
            var item = Collection[Collection.Count - 1];
            Collection.RemoveAt(Collection.Count-1);

            return item;
        }
    }
}
