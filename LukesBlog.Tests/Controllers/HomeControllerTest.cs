using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LukesBlog;
using LukesBlog.Controllers;

namespace LukesBlog.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_has_view()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About_has_view()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact_has_view()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Pictures_has_view()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Pictures() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Praise_has_view()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Praise() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Projects_has_view()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Projects() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
