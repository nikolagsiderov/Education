using NUnit.Framework;
using System;

namespace Tests
{
    public class DatabaseTests
    {
        Database.Database emptyDB;
        Database.Database fullDB;

        [SetUp]
        public void Setup()
        {
            emptyDB = new Database.Database();
            fullDB = new Database.Database();

            for (int i = 0; i < 16; i++)
            {
                fullDB.Add(i);
            }
        }

        [Test]
        public void InitializingDBWithEmptyConstructorShouldReturnCountZero()
        {
            Assert.AreEqual(0, emptyDB.Count);
        }

        [Test]
        public void InitializingDBWithConstructorShouldReturnCorrectCount()
        {
            var DB = new Database.Database(5, 4, 3, 2, 1);

            Assert.AreEqual(5, DB.Count);
        }

        [Test]
        public void AddingOneElementShouldHaveCountOne()
        {
            emptyDB.Add(321);

            Assert.AreEqual(1, emptyDB.Count);
        }

        [Test]
        public void AddingSeventeenElementShouldHaveThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => fullDB.Add(321));
        }

        [Test]
        public void AddingElementShouldAddToNextAvailableCell()
        {
            var DB = new Database.Database(1, 2, 3);

            DB.Add(5);

            Assert.AreEqual(Array.FindIndex(DB.Fetch(), x => x.Equals(5)), 3);
        }

        [Test]
        public void RemovingFromEmptyDBShouldThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => emptyDB.Remove());
        }

        [Test]
        public void RemovingShouldDecreaseCountByOne()
        {
            fullDB.Remove();

            Assert.AreEqual(15, fullDB.Count);
        }

        [Test]
        public void RemovingElementShouldRemoveFromLastCell()
        {
            var DB = new Database.Database(1, 2, 3);

            DB.Remove();

            Assert.AreEqual(DB.Count, 2);
        }

        [Test]
        public void FetchShouldReturnArrayOfIntegers()
        {
            var result = fullDB.Fetch();

            Assert.AreEqual(typeof(int[]), result.GetType());
        }
    }
}