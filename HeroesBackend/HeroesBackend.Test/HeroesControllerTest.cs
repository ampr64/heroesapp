using HeroesBackend.Common.Interfaces;
using HeroesBackend.Controllers;
using HeroesBackend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net;

namespace HeroesBackend.Test
{
    [TestClass]
    public class HeroesControllerTest
    {
        private HeroesController controller;
        private Mock<IHeroBusinessLayer> mockBusinessLayer;

        [TestInitialize]
        public void Initialize()
        {
            this.mockBusinessLayer = new Mock<IHeroBusinessLayer>();            
        }


        [TestMethod]
        public void GetOne_Ok()
        {
            int id = 1;
            this.mockBusinessLayer.Setup(x => x.GetOne(id)).Returns(new Hero { Id = id });
            this.controller = new HeroesController(mockBusinessLayer.Object);

            ActionResult<Hero> response = controller.GetOne(1);

            var result = response.Result as OkObjectResult;

            Assert.AreEqual((int)HttpStatusCode.OK, result.StatusCode);
            Assert.IsNotNull(result.Value);
        }

        [TestMethod]
        public void GetOne_ParemterEqualOrLessThanZero()
        {
            int id = 0;
            this.mockBusinessLayer.Setup(x => x.GetOne(id)).Returns(new Hero { Id = id });
            this.controller = new HeroesController(mockBusinessLayer.Object);

            ActionResult<Hero> response = controller.GetOne(0);

            var result = response.Result as StatusCodeResult;

            Assert.AreEqual((int)HttpStatusCode.InternalServerError, result.StatusCode);
            Assert.IsNull(response.Value);
        }
    }
}
