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
    public class CategoryRepositoryTests
    {
        IUnitOfWork UnitOfWork;
        List<Category> MockData;
        Mock<DataContext.DataContext> MockContext;

        [OneTimeSetUp]
        public void Setup()
        {
            Mock<DbSet<Category>> MockSet = new Mock<DbSet<Category>>();

            MockData = new List<Category>() {
                new Category(){ Id = 1, CategoryName = "Category1", Weight = 10, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 2, CategoryName = "Category2", Weight = 20, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 3, CategoryName = "Category3", Weight = 30, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 4, CategoryName = "Category4", Weight = 40, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null }               
            };

            var queryable = MockData.AsQueryable();
            MockSet.As<IQueryable<Category>>().Setup(e => e.Provider).Returns(queryable.Provider);
            MockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(queryable.Expression);
            MockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            MockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator);

            MockContext = new Mock<DataContext.DataContext>();
            MockContext.Setup(m => m.Categories).Returns(MockSet.Object);
            MockContext.Setup(m => m.SaveChanges());
            //MockContext.Setup(m => m.Categories.Add(It.IsAny<Category>())).Returns<Category>(x =>
            //{
            //    MockData.Add(x);
            //    return x;
            //});
            //MockContext.Setup(m => m.Categories.Remove(It.IsAny<Category>())).Callback<Category>(x =>
            //{
            //    MockData.Remove(x);
            //});
            UnitOfWork = new UnitOfWork(MockContext.Object);
        }

        [Test]
        public void testGetAll_ShouldGetAll_WhenInvoked()
        {
            //ARRANGE
            CompareLogic compareLogic = new CompareLogic();
            var categoryRepository = new CategoryRepository(UnitOfWork);

            List<Category> expected = new List<Category>();

            expected = new List<Category>() {
                new Category(){ Id = 1, CategoryName = "Category1", Weight = 10, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 2, CategoryName = "Category2", Weight = 20, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 3, CategoryName = "Category3", Weight = 30, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 4, CategoryName = "Category4", Weight = 40, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null }
                };

            //ACT
            var actual = categoryRepository.GetAll();
            //ASSERT
            ComparisonResult result = compareLogic.Compare(expected, actual);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            Assert.True(result.AreEqual);
        }

        [Test]
        public void testGetById_ShouldCategoryById_WhenInvokedWithId()
        {
            //ARRANGE
            CompareLogic compareLogic = new CompareLogic();
            var categoryRepository = new CategoryRepository(UnitOfWork);

            Category expected = new Category() { Id = 2, CategoryName = "Category2", Weight = 20, Created_TS = new DateTime(2018, 6, 14, 8, 0, 0), Updated_TS = null };

            //ACT
            var actual = categoryRepository.GetById(2);
            //ASSERT
            ComparisonResult result = compareLogic.Compare(expected, actual);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            Assert.True(result.AreEqual);
        }

        //[Test]
        //public void testAdd_ShouldAddCategory_WhenInvoked()
        //{
        //    //ARRANGE
        //    CompareLogic compareLogic = new CompareLogic();
        //    var categoryRepository = new CategoryRepository(UnitOfWork);

        //    Category entity = new Category() { Id = 5, CategoryName = "Category5", Weight = 50, Created_TS = new DateTime(2018, 6, 14, 8, 0, 0), Updated_TS = null };

        //    //ACT
        //    var actual = categoryRepository.Add(entity);
        //    //ASSERT
        //    MockContext.Verify(x => x.SaveChanges(), Times.Once);
        //    Assert.AreEqual(MockData.Count(), 5);
        //    ComparisonResult result = compareLogic.Compare(MockData.Last(), actual);
        //    if (!result.AreEqual)
        //        Console.WriteLine(result.DifferencesString);
        //    Assert.True(result.AreEqual);
        //}

        //[Test]
        //public void testUpdate_ShouldUpdateCategory_WhenInvokedWithCategory()
        //{
        //    //ARRANGE
        //    CompareLogic compareLogic = new CompareLogic();
        //    var categoryRepository = new CategoryRepository(UnitOfWork);

        //    Category entity = new Category() { Id = 4, CategoryName = "Category5", Weight = 50, Created_TS = new DateTime(2018, 6, 14, 8, 0, 0), Updated_TS = null };

        //    //ACT
        //    var actual = categoryRepository.Update(entity);
        //    //ASSERT
        //    MockContext.Verify(x => x.SaveChanges(), Times.Once);
        //    Assert.AreEqual(MockData.Count(), 4);
        //    ComparisonResult result = compareLogic.Compare(MockData.Last(), actual);
        //    if (!result.AreEqual)
        //        Console.WriteLine(result.DifferencesString);
        //    Assert.True(result.AreEqual);
        //}

        //[Test]
        //public void testDelete_ShouldDeleteCategory_WhenInvokedWithCategory()
        //{
        //    //ARRANGE
        //    CompareLogic compareLogic = new CompareLogic();
        //    var categoryRepository = new CategoryRepository(UnitOfWork);
       

        //    Category entity = new Category() { Id = 4, CategoryName = "Category4", Weight = 40, Created_TS = new DateTime(2018, 6, 14, 8, 0, 0), Updated_TS = null };

        //    //ACT
        //    categoryRepository.Delete(entity);

        //    var expected = MockData.FirstOrDefault(x => x.Id.Equals(4));
        //    //ASSERT
        //    MockContext.Verify(x => x.SaveChanges(), Times.Once);
        //    Assert.AreEqual(MockData.Count(), 3);
        //    ComparisonResult result = compareLogic.Compare(expected, null);
        //    if (!result.AreEqual)
        //        Console.WriteLine(result.DifferencesString);
        //    Assert.True(result.AreEqual);
        //}
    }
}
