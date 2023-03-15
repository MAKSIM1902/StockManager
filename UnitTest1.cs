using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using TS.EasyStockManager.Core.Service;
using TS.EasyStockManager.Model.Domain;
using TS.EasyStockManager.Model.ViewModel.Category;
using TS.EasyStockManager.Model.ViewModel.Store;
using TS.EasyStockManager.Web;
using TS.EasyStockManager.Web.Controllers;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
     
        [Fact]
        public void GetListUserNotNull()
        {
            var mock = new Mock<IUserService>();
            var mock1 = new Mock<IMapper>();
            var controller = new UserController(mock.Object, mock1.Object);
           

            // Act
            var result = controller.Index();

            // Assert
            Assert.NotNull(result);

        }

        [Fact]
        public void DeleteStoreTest()
        {
            var mock = new Mock<IUserService>();
            var mock1 = new Mock<IMapper>();
            var controller = new UserController(mock.Object, mock1.Object);


            // Act
            var result = controller.Delete(1);

            // Assert
            Assert.Equal(result.Id, 1);

        }

        [Fact]
        public void GetlistTranscationTest()
        {
            var mock = new Mock<ICategoryService>();
            var mock1 = new Mock<IMapper>();
            var controller = new CategoryController(mock.Object, mock1.Object);


            var modelList = new SearchCategoryViewModel()
            {
                CategoryName = "Test",
                iDisplayLength = 10,
                iDisplayStart = 0,
                Id = 1
            };

            var result = controller.Json(modelList);
            

        }

        [Fact]
        public void ConvertToJsonTest()
        {
            var mock = new Mock<ICategoryService>();
            var mock1 = new Mock<IMapper>();
            var controller = new CategoryController(mock.Object, mock1.Object);


            var modelList = new SearchCategoryViewModel()
            {
                CategoryName = "Test",
                iDisplayLength = 10,
                iDisplayStart = 0,
                Id = 1
            };

            var result = controller.Json(modelList);

            Assert.Equal(modelList, result.Value);
        }

        [Fact]
        public void ActionUpdateTest()
        {
            var mock = new Mock<IStoreService>();
            var mock1 = new Mock<IMapper>();
            var controller = new StoreController(mock.Object, mock1.Object);


            var modelList = new SearchCategoryViewModel()
            {
                CategoryName = "Test",
                iDisplayLength = 10,
                iDisplayStart = 0,
                Id = 1
            };

            var result = controller.Edit(modelList.Id);

            Assert.Equal(modelList.Id.ToString(), result.Id.ToString());


        }
        [Fact]
        public void CategoryConvertTest()
        {
            var mock = new Mock<ICategoryService>();
            var mock1 = new Mock<IMapper>();
            var controller = new CategoryController(mock.Object, mock1.Object);


            var modelList = new SearchCategoryViewModel()
            {
                CategoryName = "Test",
                iDisplayLength = 10,
                iDisplayStart = 0,
                Id = 1
            };

            var result = controller.Json(modelList);


        }
        [Fact]
        public void IndexChekNotNull()
        {
            var mock = new Mock<ICategoryService>();
            var mock1 = new Mock<IMapper>();
            var controller = new CategoryController(mock.Object, mock1.Object);

            var result = controller.Index();

            Assert.NotNull(result);
        }
        [Fact]
        public void ChekPropTest()
        {
            var mock = new Mock<ICategoryService>();
            var mock1 = new Mock<IMapper>();
            var controller = new CategoryController(mock.Object, mock1.Object);


            var result = controller.Ok();


        }

        [Fact]
        public void GetIndexTest()
        {
            var mock = new Mock<ICategoryService>();
            var mock1 = new Mock<IMapper>();
            var controller = new CategoryController(mock.Object, mock1.Object);


            var result = controller.ViewData;

            Assert.IsType<ViewDataDictionary>(result);
        }
        

    }
}
