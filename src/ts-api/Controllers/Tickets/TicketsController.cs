using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ts_api.Controllers.Tickets
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        

        [HttpGet]
        public string  Get()
        {
            return "Tickets";
        }
    }
}
