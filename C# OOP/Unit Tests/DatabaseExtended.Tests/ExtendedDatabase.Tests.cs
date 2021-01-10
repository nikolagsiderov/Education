using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        Person[] people = new Person[3];
        Person[] anotherPeople = new Person[5];
        Person[] moreThanMaxPeopleAllowed = new Person[17];

        [SetUp]
        public void Setup()
        {
            for (int i = 0; i < moreThanMaxPeopleAllowed.Length; i++)
            {
                moreThanMaxPeopleAllowed[i] = new Person(i + 1, $"Mitko{i + 1}");
            }

            people[0] = new Person(1, "Ivan");
            people[1] = new Person(2, "Stoyan");
            people[2] = new Person(3, "Kolyo");

            anotherPeople[0] = new Person(1, "Ivan");
            anotherPeople[1] = new Person(2, "Stoyan");
            anotherPeople[2] = new Person(3, "Kolyo");
            anotherPeople[3] = new Person(4, "Miro");
            anotherPeople[4] = new Person(5, "Ivailo");
        }

        [Test]
        public void ConstructorShouldAddRangeOfPeople()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(people);

            Assert.AreEqual(people.Length, database.Count);
        }

        [Test]
        public void ConstructorShouldWorkWithNoValues()
        {
            var database = new ExtendedDatabase.ExtendedDatabase();

            Assert.AreEqual(0, database.Count);
        }

        [Test]
        public void ConstructorShouldThrowArgumentExceptionIfMoreThanSixteenCollectionCountIsAdded()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var database = new ExtendedDatabase.ExtendedDatabase(moreThanMaxPeopleAllowed);
            });
        }

        [Test]
        public void AddOperationShouldThrowInvalidOperationExceptionIfTryingToAddPersonWithIDThatIsAlreadyInDB()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(anotherPeople);

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(1, "Kiro"));
            });
        }

        [Test]
        public void AddOperationShouldThrowInvalidOperationExceptionIfTryingToAddPersonWithUsernameThatIsAlreadyInDB()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(anotherPeople);

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(new Person(4, "Ivan"));
            });
        }

        [Test]
        public void AddOperationShouldAddSuccessfully()
        {
            var database = new ExtendedDatabase.ExtendedDatabase();

            database.Add(new Person(4, "Katya"));

            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void RemoveOperationShouldRemoveSuccessfully()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(anotherPeople);

            database.Remove();

            Assert.AreEqual(anotherPeople.Length - 1, database.Count);
        }

        [Test]
        public void RemoveOperationShouldThrownInvalidOperationExceptionIfDatabaseIsEmpty()
        {
            var database = new ExtendedDatabase.ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }

        [Test]
        public void FindByUsernameShouldThrowInvalidOperationExceptionIfNoSuchUserIsPresent()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(anotherPeople);

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindByUsername("Bozho");
            });
        }

        [Test]
        public void FindByUsernameShouldThrowArgumentNullExceptionIfParameterIsNull()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(anotherPeople);

            Assert.Throws<ArgumentNullException>(() =>
            {
                database.FindByUsername(null);
            });
        }

        [Test]
        public void FindByUsernameShouldWorkCorrectlyAndReturnPerson()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(anotherPeople);

            Assert.AreEqual(database.FindByUsername("Ivan").GetType(), typeof(Person));
        }

        [Test]
        public void FindByIdShouldThrowInvalidOperationExceptionIfNoSuchUserIsPresent()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(anotherPeople);

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.FindById(312);
            });
        }

        [Test]
        public void FindByIdShouldThrowArgumentOutOfRangeExceptionIfIdIsNegative()
        {
            var database = new ExtendedDatabase.ExtendedDatabase(anotherPeople);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                database.FindById(-2);
            });
        }
    }
}