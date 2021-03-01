using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bee.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace Bee.Controllers.Api
{
    [Route("api/bee")]
    public class BeeController:Controller
    {
        private readonly IBeeService beeService;

        public BeeController(IBeeService beeService)
        {
            this.beeService = beeService;
        }

        [HttpGet]
        [Route("list")]
        public JsonResult Get()
        {
            var bees = this.beeService.CreateBees();

            return new JsonResult(bees);
        }

        [HttpGet]
        [Route("damage/{id}")]
        public JsonResult Damage(int id)
        {
            var bees = this.beeService.Damage(id);

            return new JsonResult(bees);
        }
    }
}
