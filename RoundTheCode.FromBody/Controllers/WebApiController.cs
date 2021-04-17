using Microsoft.AspNetCore.Mvc;
using RoundTheCode.FromBody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTheCode.FromBody.Controllers
{
    [ApiController]
    [Route("webapi")]
    public class WebApiController : Controller
    {
        [HttpGet]
        public Customer Get([FromQuery] Customer customer)
        {
            return customer;
        }

        [HttpPost]
        public Customer Post(Customer customer)
        {
            return customer;
        }
    }
}
