using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAL;
using DTO;
using System.Web.Script.Serialization;

namespace Doms.Controllers.api
{
    public class PizzaController : ApiController
    {
        PizzaBAL pizzaBAL;
        public PizzaController()
        {
            pizzaBAL = new PizzaBAL();
        }
        [HttpGet]
        public IHttpActionResult GetPizzas()
        {
            var pizzaList = pizzaBAL.GetAllPizzas();
            return Ok(pizzaList);
        }

        [HttpPost]
        public IHttpActionResult PostOrder([FromBody]CartItemDto[] cartItemDtos)
        {
            pizzaBAL.CreateOrder(cartItemDtos.ToList());
            return Ok(cartItemDtos);
        }

    }
}
