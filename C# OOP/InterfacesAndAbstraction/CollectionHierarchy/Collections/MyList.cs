using System.Collections.Generic;

namespace CollectionHierarchy.Collections
{
    public class MyList<T> : Contracts.ICollection<T>
    {
        public MyList(int count)
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
            var item = Collection[0];
            Collection.RemoveAt(0);

            return item;
        }

        public int Used()
        {
            return Collection.Count;
        }
    }
}
