

using System;
using System.Web.Mvc;
using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]

        public void ViewSelectionTest()
        {
            //Arrange - create the controller

            //ExampleController target = new ExampleController();

            ////Act - call the action method

            //RedirectToRouteResult result = target.Redirect();


            ////Assert

            //Assert.IsFalse(result.Permanent);
            //Assert.AreEqual("Example", result.RouteValues["controller"]);
            //Assert.AreEqual("Index", result.RouteValues["action"]);
            //Assert.AreEqual("MyID", result.RouteValues["ID"]);

            ExampleController target = new ExampleController();

            HttpStatusCodeResult result = target.StatusCode();

            Assert.AreEqual(404, result.StatusCode);
        }
    }
}
