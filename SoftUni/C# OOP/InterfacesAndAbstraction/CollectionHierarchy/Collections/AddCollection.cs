using System.Collections.Generic;

namespace CollectionHierarchy.Collections
{
    public class AddCollection<T> : Contracts.IAdd_able<T>
    {
        public AddCollection(int count)
        {
            Collection = new List<T>(count);
        }

        private List<T> Collection { get; set; }

        public int Add(T item)
        {
            Collection.Add(item);

            return Collection.Count - 1;
        }
    }
}
