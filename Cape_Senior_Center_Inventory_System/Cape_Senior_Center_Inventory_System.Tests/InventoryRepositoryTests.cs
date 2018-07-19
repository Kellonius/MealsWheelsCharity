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
            Mock<DbSet<Category>> mockedCategorySet = new Mock<DbSet<Category>>();

            mockedInventoryData = new List<Inventory>() {
                new Inventory(){ },
                new Inventory(){ },
                new Inventory(){ },
                new Inventory(){ }
            };

            var queryable = mockedInventoryData.AsQueryable();
            mockedCategorySet.As<IQueryable<Inventory>>().Setup(e => e.Provider).Returns(queryable.Provider);
            mockedCategorySet.As<IQueryable<Inventory>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockedCategorySet.As<IQueryable<Inventory>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockedCategorySet.As<IQueryable<Inventory>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator);

            mockedContext = new Mock<DataContext.DataContext>();
            mockedContext.Setup(m => m.Categories).Returns(mockedCategorySet.Object);
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
