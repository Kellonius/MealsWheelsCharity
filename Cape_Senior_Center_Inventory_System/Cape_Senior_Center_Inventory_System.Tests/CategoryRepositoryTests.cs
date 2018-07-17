﻿using Cape_Senior_Center_Inventory_System.DataContext.Models;
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
        IUnitOfWork unitOfWork;
        List<Category> mockedCategoryData;
        Mock<DataContext.DataContext> mockedContext;

        [OneTimeSetUp]
        public void Setup()
        {
            Mock<DbSet<Category>> mockedCategorySet = new Mock<DbSet<Category>>();

            mockedCategoryData = new List<Category>() {
                new Category(){ Id = 1, CategoryName = "Category1", Weight = 10, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 2, CategoryName = "Category2", Weight = 20, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 3, CategoryName = "Category3", Weight = 30, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null },
                new Category(){ Id = 4, CategoryName = "Category4", Weight = 40, Created_TS = new DateTime(2018, 6, 14, 8, 0,0) , Updated_TS = null }
            };

            var queryable = mockedCategoryData.AsQueryable();
            mockedCategorySet.As<IQueryable<Category>>().Setup(e => e.Provider).Returns(queryable.Provider);
            mockedCategorySet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockedCategorySet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockedCategorySet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator);

            mockedContext = new Mock<DataContext.DataContext>();
            mockedContext.Setup(m => m.Categories).Returns(mockedCategorySet.Object);
            mockedContext.Setup(m => m.SaveChanges());

            mockedContext.Setup(m => m.Categories.Add(It.IsAny<Category>())).Returns<Category>(x =>
             {
                 mockedCategoryData.Add(x);
                 return x;
             });


            mockedContext.Setup(m => m.Categories.Remove(It.IsAny<Category>())).Callback<Category>(x =>
            {
                //mockedCategoryData.Remove(mockedCategoryData.First(y => y.Id.Equals(x.Id)));
                mockedCategoryData.Remove(x);
            });

            unitOfWork = new UnitOfWork(mockedContext.Object);
        }

        [Test]
        public void testGetAll_ShouldGetAll_WhenInvoked()
        {
            //ARRANGE
            CompareLogic compareLogic = new CompareLogic();
            var categoryRepository = new CategoryRepository(unitOfWork);

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
            var categoryRepository = new CategoryRepository(unitOfWork);

            Category expected = new Category() { Id = 2, CategoryName = "Category2", Weight = 20, Created_TS = new DateTime(2018, 6, 14, 8, 0, 0), Updated_TS = null };

            //ACT
            var actual = categoryRepository.GetById(2);
            //ASSERT
            ComparisonResult result = compareLogic.Compare(expected, actual);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            Assert.True(result.AreEqual);
        }

        [Test]
        public void testAdd_ShouldAddCategory_WhenInvoked()
        {
            //ARRANGE
            CompareLogic compareLogic = new CompareLogic();
            var categoryRepository = new CategoryRepository(unitOfWork);

            Category entity = new Category() { Id = 5, CategoryName = "Category5", Weight = 50, Created_TS = new DateTime(2018, 6, 14, 8, 0, 0), Updated_TS = null };

            //ACT
            var actual = categoryRepository.Add(entity);
            //ASSERT
            mockedContext.Verify(x => x.SaveChanges(), Times.Once);
            Assert.AreEqual(mockedCategoryData.Count(), 5);
            ComparisonResult result = compareLogic.Compare(mockedCategoryData.Last(), actual);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            Assert.True(result.AreEqual);
        }

        [Test]
        public void testUpdate_ShouldUpdateCategory_WhenInvokedWithCategory()
        {
            //ARRANGE
            CompareLogic compareLogic = new CompareLogic();
            var categoryRepository = new CategoryRepository(unitOfWork);

            Category entity = new Category() { Id = 4, CategoryName = "Category5", Weight = 50, Created_TS = new DateTime(2018, 6, 14, 8, 0, 0), Updated_TS = null };

            //ACT
            var actual = categoryRepository.Update(entity);
            //ASSERT
            mockedContext.Verify(x => x.SaveChanges(), Times.Once);
            Assert.AreEqual(mockedCategoryData.Count(), 4);
            ComparisonResult result = compareLogic.Compare(mockedCategoryData.Last(), actual);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            Assert.True(result.AreEqual);
        }

        [Test]
        public void testDelete_ShouldDeleteCategory_WhenInvokedWithCategory()
        {
            //ARRANGE
            CompareLogic compareLogic = new CompareLogic();
            var categoryRepository = new CategoryRepository(unitOfWork);


            Category entity = new Category() { Id = 5, CategoryName = "Category5", Weight = 50, Created_TS = new DateTime(2018, 6, 14, 8, 0, 0), Updated_TS = null };

            mockedCategoryData.Add(entity);
            
            //ACT
            categoryRepository.Delete(entity);

            var expected = mockedCategoryData.FirstOrDefault(x => x.Id.Equals(5));
            //ASSERT
            mockedContext.Verify(x => x.SaveChanges(), Times.Once);
            Assert.AreEqual(mockedCategoryData.Count(), 4);
            ComparisonResult result = compareLogic.Compare(expected, null);
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            Assert.True(result.AreEqual);
        }
    }
}
