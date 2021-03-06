using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Interfaces;
using OrderManagement.Models;
using System.Text.Json;

namespace OrderManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderManager orderManager;

        public OrderController(IOrderManager orderMngr)
        {
            orderManager = orderMngr;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(JsonSerializer.Serialize(orderManager.Get()));
        }

        [HttpPost]
        public ActionResult<string> Post(Order order)
        {
            return Ok(orderManager.Transmit(order));
        }
    }
}