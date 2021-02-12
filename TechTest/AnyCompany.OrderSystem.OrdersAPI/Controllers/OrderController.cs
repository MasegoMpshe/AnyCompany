using AnyCompany.OrderSystem.Application.Communication;
using AnyCompany.OrderSystem.Application.Tasks.Command;
using AnyCompany.OrderSystem.Core.DomainModel.RequestDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnyCompany.OrderSystem.OrdersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMessageService messageService;

        public OrderController(IMessageService messageService)
        {
            this.messageService = messageService;
        }


     
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateOrderAsync([FromBody] CreateOrderRequest createOrderRequest)
        {
            var results = await messageService.Send(new CreateOrderCommand { CommandData = createOrderRequest });
            return Ok(results);
        }

        
    }
}
