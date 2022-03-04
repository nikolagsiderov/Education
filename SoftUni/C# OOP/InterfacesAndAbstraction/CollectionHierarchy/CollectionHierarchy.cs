using System;
using System.Collections.Generic;
using CollectionHierarchy.Contracts;
using CollectionHierarchy.Collections;

namespace CollectionHierarchy
{
    class CollectionHierarchy
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var removeOperations = int.Parse(Console.ReadLine());
            var result = new List<string>();

            var addCollection = new AddCollection<string>(items.Length);
            var addRemoveCollection = new AddRemoveCollection<string>(items.Length);
            var myList = new MyList<string>(items.Length);

            result.AddRange(AddItemsToCollection(addCollection, items));
            result.AddRange(AddItemsToCollection(addRemoveCollection, items));
            result.AddRange(AddItemsToCollection(myList, items));

            result.AddRange(RemoveItemsToCollection(addRemoveCollection, removeOperations));
            result.AddRange(RemoveItemsToCollection(myList, removeOperations));

            OutputResult(items, result, removeOperations);
        }

        private static void OutputResult(string[] items, List<string> result, int removeOperations)
        {
            var removeCollectionCounter = 0;
            var indexCollectionCounter = 0;

            for (int i = 0; i < result.Count; i++)
            {
                var output = result[i];

                Console.Write(output + " ");

                if (i < items.Length * 3)
                {
                    indexCollectionCounter++;

                    if (indexCollectionCounter == items.Length)
                    {
                        indexCollectionCounter = 0;
                        Console.WriteLine();
                    }
                }
                else
                {
                    removeCollectionCounter++;

                    if (removeCollectionCounter == removeOperations)
                    {
                        removeCollectionCounter = 0;
                        Console.WriteLine();
                    }
                }
            }
        }

        private static List<string> AddItemsToCollection(IAdd_able<string> collection, string[] items)
        {
            var result = new List<string>();

            foreach (var item in items)
            {
                result.Add(collection.Add(item).ToString());
            }

            return result;
        }

        private static List<string> RemoveItemsToCollection(IRemoveable<string> collection, int removeOperations)
        {
            var result = new List<string>();

            for (int i = 0; i < removeOperations; i++)
            {
                result.Add(collection.Remove());
            }

            return result;
        }
    }
}
