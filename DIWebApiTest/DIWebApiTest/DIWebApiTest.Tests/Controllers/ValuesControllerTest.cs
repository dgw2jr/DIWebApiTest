using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DIWebApiTest;
using DIWebApiTest.Controllers;
using DIWebApiTest.Models;
using Moq;

namespace DIWebApiTest.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        private Mock<IGreeter> greeter = new Mock<IGreeter>();
        private Mock<IIdProvider> idProvider = new Mock<IIdProvider>();

        private ValuesController controller
        {
            get
            {
                return new ValuesController(greeter.Object, idProvider.Object);
            }
        }

        [TestMethod]
        public void Get()
        {
            // Arrange
            greeter.Setup(s => s.Greet()).Returns("1");
            idProvider.Setup(s => s.Next()).Returns(1);

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("1", result.ElementAt(0));
            Assert.AreEqual(1.ToString(), result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
