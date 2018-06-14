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
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.Tests
{
    [TestFixture]
    public class CategoryRepositoryTests
    {
        IUnitOfWork UnitOfWork;

        [OneTimeSetUp]
        public void Setup()
        {
            Mock<DbSet<Category>> MockSet = new Mock<DbSet<Category>>();
            List<Category> mockedData = new List<Category>();



            mockedData = new List<Category>() {
                new Category(){ Id = 1, CategoryName = "Category1", Weight = 1, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 1, CategoryName = "Category2", Weight = 2, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 1, CategoryName = "Category3", Weight = 3, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 1, CategoryName = "Category4", Weight = 4, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null }               
            };

            var queryable = mockedData.AsQueryable();
            MockSet.As<IQueryable<Category>>().Setup(e => e.Provider).Returns(queryable.Provider);
            MockSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(queryable.Expression);
            MockSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            MockSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator);

            var MockContext = new Mock<DataContext.DataContext>();
            MockContext.Setup(m => m.Categories).Returns(MockSet.Object);
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
                new Category(){ Id = 1, CategoryName = "Category1", Weight = 1, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 1, CategoryName = "Category2", Weight = 2, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 1, CategoryName = "Category3", Weight = 3, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 1, CategoryName = "Category4", Weight = 4, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null }
                };

            //ACT
            var actual = categoryRepository.GetAll();
            //ASSERT
            ComparisonResult result = compareLogic.Compare(expected, actual);
            Assert.True(result.AreEqual);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);

        }
    }
}
