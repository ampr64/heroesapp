using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroesBackend.Common.Interfaces;
using HeroesBackend.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeroesBackend.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class HerosHomesController : ControllerBase
    {
        private IHeroHomeBusinessLayer businessLayer;

        public HerosHomesController(IHeroHomeBusinessLayer businessLayer)
        {
            this.businessLayer = businessLayer;
        }

        [HttpGet]
        public ActionResult<IEnumerable<HeroHome>> All()
        {
            return Ok(businessLayer.GetAll());
        }
    }
}
