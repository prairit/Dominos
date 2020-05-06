using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAL;

namespace Doms.Controllers.api
{
    public class PizzaController : ApiController
    {
        PizzaBAL pizzaBAL;
        public PizzaController()
        {
            pizzaBAL = new PizzaBAL();
        }

        public IHttpActionResult GetPizzas()
        {
            var pizzaList = pizzaBAL.GetAllPizzas();
            return Ok(pizzaList);
        }
    }
}
