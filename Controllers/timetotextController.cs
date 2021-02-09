using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace clock.Controllers
{
    [ApiController]
    [Route("[timetotext]")]
    public class timetotext : ControllerBase
    {
     [HttpPost]

     public IActionResult timetotext([FromBody] timetotext model){



     }
    }
}