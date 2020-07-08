using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
//using UserService.Repository;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET: api/Order/getorderbyuserid/{id}
        [HttpGet("/api/order/getorderbyuserid/{id}")]
        public IActionResult GetOrderByUserId(int id)
        {
            List<Order> orders = new List<Order> {
                                           new Order { OrderId = 1, OrderAmount = 1234, OrderDate = Convert.ToDateTime("22/01/2020") },
                                           new Order { OrderId = 2, OrderAmount = 4434, OrderDate = Convert.ToDateTime("23/02/2020") },
                                           new Order { OrderId = 3, OrderAmount = 1734, OrderDate = Convert.ToDateTime("24/03/2020") } };
            return new OkObjectResult(orders);
        }
    }
}
