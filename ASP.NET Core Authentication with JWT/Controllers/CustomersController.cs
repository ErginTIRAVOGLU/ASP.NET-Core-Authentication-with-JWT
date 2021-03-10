using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Authentication_with_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController:ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get() => new string[] { "John Doe", "Jane Doe" };

    }
}
