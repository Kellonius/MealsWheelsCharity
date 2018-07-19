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
    public class ItemRepositoryTests
    {
        IUnitOfWork unitOfWork;
        List<Item> mockedInventoryData;
        Mock<DataContext.DataContext> mockedContext;

        [OneTimeSetUp]
        public void Setup()
        {
            Mock<DbSet<Category>> mockedCategorySet = new Mock<DbSet<Category>>();

            mockedInventoryData = new List<Item>() {
                new Item(){ },
                new Item(){ },
                new Item(){ },
                new Item(){ }
            };

            var queryable = mockedInventoryData.AsQueryable();
            mockedCategorySet.As<IQueryable<Item>>().Setup(e => e.Provider).Returns(queryable.Provider);
            mockedCategorySet.As<IQueryable<Item>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockedCategorySet.As<IQueryable<Item>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockedCategorySet.As<IQueryable<Item>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator);

            mockedContext = new Mock<DataContext.DataContext>();
            mockedContext.Setup(m => m.Categories).Returns(mockedCategorySet.Object);
            mockedContext.Setup(m => m.SaveChanges());

            mockedContext.Setup(m => m.Items.Add(It.IsAny<Item>())).Returns<Item>(x =>
             {
                 mockedInventoryData.Add(x);
                 return x;
             });


            mockedContext.Setup(m => m.Items.Remove(It.IsAny<Item>())).Callback<Item>(x =>
            {
                //mockedCategoryData.Remove(mockedCategoryData.First(y => y.Id.Equals(x.Id)));
                mockedInventoryData.Remove(x);
            });

            unitOfWork = new UnitOfWork(mockedContext.Object);
        }

        [Test]
        public void testGetAll_ShouldGetAll_WhenInvoked()
        {
        }

        [Test]
        public void testGetById_ShouldCategoryById_WhenInvokedWithId()
        {
        }

        [Test]
        public void testAdd_ShouldAddCategory_WhenInvoked()
        {
        }

        [Test]
        public void testUpdate_ShouldUpdateCategory_WhenInvokedWithCategory()
        {
        }

        [Test]
        public void testDelete_ShouldDeleteCategory_WhenInvokedWithCategory()
        {
        }
    }
}
