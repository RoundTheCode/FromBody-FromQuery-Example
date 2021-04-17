using Microsoft.AspNetCore.Mvc;
using RoundTheCode.FromBody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTheCode.FromBody.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [HttpGet]
        public Customer Get(Customer customer)
        {
            return customer;
        }

        [HttpPost]
        public Customer Post([FromBody] Customer customer)
        {
            return customer;
        }
    }
}
