using Cape_Senior_Center_Inventory_System.DataContext.Models;
using Cape_Senior_Center_Inventory_System.Implementations;
using Cape_Senior_Center_Inventory_System.Interfaces;
using KellermanSoftware.CompareNetObjects;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Cape_Senior_Center_Inventory_System.Tests
{
    [TestFixture]
    public class InventoryRepositoryTests
    {
        IUnitOfWork unitOfWork;
        List<Inventory> mockedInventoryData;
        Mock<DataContext.DataContext> mockedContext;

        [OneTimeSetUp]
        public void Setup()
        {
            Mock<DbSet<Inventory>> mockInventory = new Mock<DbSet<Inventory>>();


            var item1 = new Item() { Created_TS = DateTime.Now, Id = 1, Name = "Item 1", Quantity = 11, UnitOfMeasure = new UnitOfMeasure() { Id = 111, Unit = "1111" }, UomId = 11111, Updated_TS = DateTime.Now.AddHours(1) };
            var item2 = new Item() { Created_TS = DateTime.Now, Id = 2, Name = "Item 2", Quantity = 22, UnitOfMeasure = new UnitOfMeasure() { Id = 222, Unit = "2222" }, UomId = 22222, Updated_TS = DateTime.Now.AddHours(1) };
            var item3 = new Item() { Created_TS = DateTime.Now, Id = 3, Name = "Item 3", Quantity = 33, UnitOfMeasure = new UnitOfMeasure() { Id = 333, Unit = "3333" }, UomId = 33333, Updated_TS = DateTime.Now.AddHours(1) };

            mockedInventoryData = new List<Inventory>() {
                new Inventory() {Created_TS = DateTime.Now, Id = 1, ItemId = 11, Item = item1, QuantityChange = 111, Updated_TS = DateTime.Now.AddHours(1)},
                new Inventory() {Created_TS = DateTime.Now, Id = 2, ItemId = 11, Item = item2, QuantityChange = 222, Updated_TS = DateTime.Now.AddHours(1)},
                new Inventory() {Created_TS = DateTime.Now, Id = 3, ItemId = 11, Item = item3, QuantityChange = 333, Updated_TS = DateTime.Now.AddHours(1)}
            };

            var queryable = mockedInventoryData.AsQueryable();
            mockInventory.As<IQueryable<Inventory>>().Setup(e => e.Provider).Returns(queryable.Provider);
            mockInventory.As<IQueryable<Inventory>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockInventory.As<IQueryable<Inventory>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockInventory.As<IQueryable<Inventory>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator);

            mockedContext = new Mock<DataContext.DataContext>();
            mockedContext.Setup(m => m.Inventories).Returns(mockInventory.Object);
            mockedContext.Setup(m => m.SaveChanges());

            mockedContext.Setup(m => m.Inventories.Add(It.IsAny<Inventory>())).Returns<Inventory>(x =>
             {
                 mockedInventoryData.Add(x);
                 return x;
             });


            mockedContext.Setup(m => m.Inventories.Remove(It.IsAny<Inventory>())).Callback<Inventory>(x =>
            {
                mockedInventoryData.Remove(mockedInventoryData.First(y => y.Id.Equals(x.Id)));
                //mockedInventoryData.Remove(x);
            });

            unitOfWork = new UnitOfWork(mockedContext.Object);
        }

        [Test]
        public void testGetAll_ShouldGetAll_WhenInvoked()
        {
            CompareLogic compareLogic = new CompareLogic();
            var InventoryRepository = new InventoryRepository(unitOfWork);

            var item1 = new Item() { Created_TS = DateTime.Now, Id = 1, Name = "Item 1", Quantity = 11, UnitOfMeasure = new UnitOfMeasure() { Id = 111, Unit = "1111" }, UomId = 11111, Updated_TS = DateTime.Now.AddHours(1) };
            var item2 = new Item() { Created_TS = DateTime.Now, Id = 2, Name = "Item 2", Quantity = 22, UnitOfMeasure = new UnitOfMeasure() { Id = 222, Unit = "2222" }, UomId = 22222, Updated_TS = DateTime.Now.AddHours(1) };
            var item3 = new Item() { Created_TS = DateTime.Now, Id = 3, Name = "Item 3", Quantity = 33, UnitOfMeasure = new UnitOfMeasure() { Id = 333, Unit = "3333" }, UomId = 33333, Updated_TS = DateTime.Now.AddHours(1) };

            List<Inventory> expected = new List<Inventory>()
            {
                new Inventory() {Created_TS = DateTime.Now, Id = 1, ItemId = 11, Item = item1, QuantityChange = 111, Updated_TS = DateTime.Now.AddHours(1)},
                new Inventory() {Created_TS = DateTime.Now, Id = 2, ItemId = 11, Item = item2, QuantityChange = 222, Updated_TS = DateTime.Now.AddHours(1)},
                new Inventory() {Created_TS = DateTime.Now, Id = 3, ItemId = 11, Item = item3, QuantityChange = 333, Updated_TS = DateTime.Now.AddHours(1)},
            };

            var actual = InventoryRepository.GetAll();

            ComparisonResult result = compareLogic.Compare(expected, actual);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            Assert.True(result.AreEqual);
        }

        [Test]
        public void testGetById_ShouldInventoryById_WhenInvokedWithId()
        {

        }

        [Test]
        public void testAdd_ShouldAddInventory_WhenInvoked()
        {

        }

        [Test]
        public void testUpdate_ShouldUpdateInventory_WhenInvokedWithInventory()
        {

        }

        [Test]
        public void testDelete_ShouldDeleteInventory_WhenInvokedWithInventory()
        {

        }
    }
}
