using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        Car car;

        [SetUp]
        public void Setup()
        {
            var make = "Honda";
            var model = "Accord";
            var fuelConsumption = 5.5;
            var fuelCapacity = 37.7;

            car = new Car(make, model, fuelConsumption, fuelCapacity);
        }

        [Test]
        public void ConstructorWorksPerfectlyFine()
        {
            var make = "Honda";
            var model = "Accord";
            var fuelConsumption = 5.5;
            var fuelCapacity = 37.7;

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }

        [Test]
        public void MakePropertyThrowsArgumentExceptionIfValueIsEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var make = "";
                var model = "Accord";
                var fuelConsumption = 5.5;
                var fuelCapacity = 37.7;

                var car = new Car(make, model, fuelConsumption, fuelCapacity);
            }, "Make cannot be null or empty!");
        }

        [Test]
        public void MakePropertyThrowsArgumentExceptionIfValueIsNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                string make = null;
                var model = "Accord";
                var fuelConsumption = 5.5;
                var fuelCapacity = 37.7;

                var car = new Car(make, model, fuelConsumption, fuelCapacity);
            }, "Make cannot be null or empty!");
        }

        [Test]
        public void ModelPropertyThrowsArgumentExceptionIfValueIsNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var make = "Honda";
                string model = null;
                var fuelConsumption = 5.5;
                var fuelCapacity = 37.7;

                var car = new Car(make, model, fuelConsumption, fuelCapacity);
            }, "Model cannot be null or empty!");
        }

        [Test]
        public void ModelPropertyThrowsArgumentExceptionIfValueIsEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var make = "Honda";
                var model = "";
                var fuelConsumption = 5.5;
                var fuelCapacity = 37.7;

                var car = new Car(make, model, fuelConsumption, fuelCapacity);
            }, "Model cannot be null or empty!");
        }

        [Test]
        public void FuelConsumptionPropertyThrowsArgumentExceptionIfValueNegativeOrZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var make = "Honda";
                var model = "Accord";
                var fuelConsumption = 0;
                var fuelCapacity = 37.7;

                var car = new Car(make, model, fuelConsumption, fuelCapacity);
            }, "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        public void FuelCapacityPropertyThrowsArgumentExceptionIfValueNegativeOrZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var make = "Honda";
                var model = "Accord";
                var fuelConsumption = 5.5;
                var fuelCapacity = -1.2;

                var car = new Car(make, model, fuelConsumption, fuelCapacity);
            }, "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        public void FuelAmountPropertyIsZeroWhenCarIsInitialized()
        {
            Assert.AreEqual(0, car.FuelAmount);
        }

        [Test]
        public void RefuelWorksProperly()
        {
            var fuelToRefuel = 20.0;

            car.Refuel(fuelToRefuel);

            Assert.AreEqual(fuelToRefuel, car.FuelAmount);
        }

        [Test]
        public void RefuelFunctionSetsAmountToCapacityIfAmountIsLargerThanCapacity()
        {
            var fuelToRefuel = 50.0;

            car.Refuel(fuelToRefuel);

            Assert.AreEqual(car.FuelCapacity, car.FuelAmount);
        }

        [Test]
        public void RefuelThrowsArgumentExceptionIfFuelToRefuelIsZeroOrNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var fuelToRefuel = -1.2;

                car.Refuel(fuelToRefuel);
            }, "Fuel amount cannot be zero or negative!");
        }
    }
}